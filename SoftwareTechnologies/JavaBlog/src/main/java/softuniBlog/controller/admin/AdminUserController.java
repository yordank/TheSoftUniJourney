package softuniBlog.controller.admin;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.crypto.bcrypt.BCryptPasswordEncoder;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.util.StringUtils;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import softuniBlog.bindingModel.UserBindingModel;
import softuniBlog.bindingModel.UserEditBindingModel;
import softuniBlog.entity.Article;
import softuniBlog.entity.Role;
import softuniBlog.entity.User;
import softuniBlog.repository.ArticleRepository;
import softuniBlog.repository.RoleRepository;
import softuniBlog.repository.UserRepository;

import java.util.HashSet;
import java.util.List;
import java.util.Set;

/**
 * Created by ADMIN on 28.11.2016 г..
 */
@Controller
@RequestMapping("/admin/users")
public class AdminUserController {

    @Autowired
    private UserRepository userRepository;
    @Autowired
    private ArticleRepository articleRepository;
    @Autowired
    private RoleRepository roleRepository;



    @GetMapping("/")
    public String listUsers(Model model){

        List<User> users=userRepository.findAll();

        model.addAttribute("users",users);
        model.addAttribute("view","admin/user/list");

        return "base-layout";

    }

    @GetMapping("/edit/{id}")
    public String edit(@PathVariable Integer id,Model model){

        if(!this.userRepository.exists(id))
        {
            return "redirect:/admin/users/";
        }

        User user=userRepository.findOne(id);
        List<Role>roles=this.roleRepository.findAll();

        model.addAttribute("user",user);
        model.addAttribute("roles",roles);
        model.addAttribute("view","admin/user/edit");

        return "base-layout";
    }

    @PostMapping("/edit/{id}")
    public String editProcess(@PathVariable Integer id, UserEditBindingModel userBindingModel){

        if(!this.userRepository.exists(id))
        {
            return "redirect:/admin/users";
        }
        User user=this.userRepository.findOne(id);


        if(!StringUtils.isEmpty(userBindingModel.getPassword())&&!StringUtils.isEmpty(userBindingModel.getConfirmPassword()))
        {
            if(userBindingModel.getPassword().equals(userBindingModel.getConfirmPassword())){
                BCryptPasswordEncoder bCryptPasswordEncoder= new BCryptPasswordEncoder();

                user.setPassword(bCryptPasswordEncoder.encode(userBindingModel.getPassword()));
            }
        }

        user.setFullName(userBindingModel.getFullName());
        user.setEmail(userBindingModel.getEmail());

        Set<Role> roles=new HashSet<>();

        for(Integer roleId:userBindingModel.getRoles()){
            roles.add(this.roleRepository.findOne(roleId));
        }
        user.setRoles(roles);

        this.userRepository.saveAndFlush(user);

        return "redirect:/admin/users/";

    }


    @GetMapping("/delete/{id}")
    public String delete(@PathVariable Integer id,Model model){

        if(!this.userRepository.exists(id))
        {
            return "redirect:/admin/users/";
        }

        User user=userRepository.findOne(id);


        model.addAttribute("user",user);
        model.addAttribute("view","admin/user/delete");

        return "base-layout";
    }







    @PostMapping("/delete/{id}")
    public String deleteProcess(@PathVariable Integer id){

        if(!this.userRepository.exists(id))
        {
            return "redirect:/admin/users/";
        }

        User user=userRepository.findOne(id);


         for(Article article:user.getArticles()){
             this.articleRepository.delete(article);
         }

         this.userRepository.delete(user);


        return "redirect:/admin/users/";
    }






}
