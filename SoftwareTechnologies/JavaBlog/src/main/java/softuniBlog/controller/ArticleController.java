package softuniBlog.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.access.prepost.PreAuthorize;
import org.springframework.security.authentication.AnonymousAuthenticationProvider;
import org.springframework.security.authentication.AnonymousAuthenticationToken;
import org.springframework.security.core.context.SecurityContext;
import org.springframework.security.core.context.SecurityContextHolder;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import softuniBlog.bindingModel.ArticleBindingModel;
import softuniBlog.entity.Article;
import softuniBlog.entity.Category;
import softuniBlog.entity.Tag;
import softuniBlog.entity.User;
import softuniBlog.repository.ArticleRepository;
import softuniBlog.repository.CategoryRepository;
import softuniBlog.repository.TagRepository;
import softuniBlog.repository.UserRepository;

import java.util.HashSet;
import java.util.List;
import java.util.stream.Collector;
import java.util.stream.Collectors;

/**
 * Created by ADMIN on 27.11.2016 г..
 */
@Controller
public class ArticleController {

    @Autowired
    private ArticleRepository articleRepository;
    @Autowired
    private UserRepository userRepository;

    @Autowired
    private CategoryRepository categoryRepository;

    @Autowired
    private TagRepository tagRepository;

    @GetMapping("/article/create")
    @PreAuthorize("isAuthenticated()")
    public String create(Model model){

        model.addAttribute("view","article/create");

        List<Category>categories=this.categoryRepository.findAll();

        model.addAttribute("categories",categories);

        return "base-layout";
    }

    @PostMapping("/article/create")
    @PreAuthorize("isAuthenticated()")
    public String createProcess(ArticleBindingModel articleBindingModel){

        UserDetails user=(UserDetails) SecurityContextHolder.getContext().getAuthentication().getPrincipal();

        User userEntity=this.userRepository.findByEmail(user.getUsername());
        Category category=this.categoryRepository.findOne(articleBindingModel.getCategoryId());
        HashSet<Tag>tags=this.findTagsFromString(articleBindingModel.getTagString());

        Article articleEntity=new Article(
                articleBindingModel.getTitle(),
                articleBindingModel.getContent(),
                userEntity,
                category,
                tags
        );

        this.articleRepository.saveAndFlush(articleEntity);

        return "redirect:/";

    }

    @GetMapping("article/{id}")
    public String details(Model model,@PathVariable Integer id){

        if(!this.articleRepository.exists(id)) {
            return "redirect:/";
        }

        Article article=this.articleRepository.findOne(id);


        model.addAttribute("article",article);
        model.addAttribute("view","article/details");

        if(!(SecurityContextHolder.getContext().getAuthentication() instanceof AnonymousAuthenticationToken))
        {
            UserDetails principal=(UserDetails)SecurityContextHolder.getContext().getAuthentication().getPrincipal();
            User userEntity=this.userRepository.findByEmail(principal.getUsername());

            model.addAttribute("user",userEntity);
        }

        return "base-layout";

    }
    @GetMapping("/article/edit/{id}")
    @PreAuthorize("isAuthenticated()")
    public String edit(@PathVariable Integer id,Model model){

        if(!this.articleRepository.exists(id)) {

            return "redirect:/" ;
        }

        Article article=this.articleRepository.findOne(id);

        if(!isUserAuthorOrAdmin(article))
        {
            return "redirect:/article/"+id;
        }

        List<Category>categories=this.categoryRepository.findAll();
        String tagString=article.getTags().stream().map(Tag::getName).collect(Collectors.joining(","));

        model.addAttribute("view","article/edit");
        model.addAttribute("article",article);
        model.addAttribute("categories",categories);
        model.addAttribute("tags",tagString);

        return "base-layout";


    }


    @PostMapping("/article/edit/{id}")
    @PreAuthorize("isAuthenticated()")
    public String editProcess(@PathVariable Integer id,ArticleBindingModel articleBindingModel){

        if(!this.articleRepository.exists(id)) {

            return "redirect:/" ;
        }

        Article article=this.articleRepository.findOne(id);

        if(!isUserAuthorOrAdmin(article))
        {
            return "redirect:/article/"+id;
        }

        Category category=this.categoryRepository.findOne(articleBindingModel.getCategoryId());
        HashSet<Tag>tags=this.findTagsFromString(articleBindingModel.getTagString());

        article.setCategory(category);
        article.setContent(articleBindingModel.getContent());
        article.setTitle(articleBindingModel.getTitle());
        article.setTags(tags);

       this.articleRepository.saveAndFlush(article);


        return "redirect:/article/"+article.getId();


    }

    @GetMapping("/article/delete/{id}")
    @PreAuthorize("isAuthenticated()")
    public String delete(Model model,@PathVariable Integer id){

        if(!this.articleRepository.exists(id)) {

            return "redirect:/" ;
        }

        Article article=this.articleRepository.findOne(id);

        if(!isUserAuthorOrAdmin(article))
        {
            return "redirect:/article/"+id;
        }

        model.addAttribute("view","article/delete");
        model.addAttribute("article",article);


        return "base-layout";


    }


    @PostMapping("/article/delete/{id}")
    @PreAuthorize("isAuthenticated()")
    public String deleteProcess(@PathVariable Integer id){

        if(!this.articleRepository.exists(id)) {

            return "redirect:/" ;
        }

        Article article=this.articleRepository.findOne(id);

        if(!isUserAuthorOrAdmin(article))
        {
            return "redirect:/article/"+id;
        }

        this.articleRepository.delete(article);


        return "redirect:/";


    }

    private HashSet<Tag>findTagsFromString(String tagString){

        HashSet<Tag>tags=new HashSet<>();
        String[]tagNames=tagString.split(",\\s*");

        for(String tagName:tagNames){
            Tag currentTag=this.tagRepository.findByname(tagName);

            if(currentTag==null)
            {
                currentTag=new Tag(tagName);
                this.tagRepository.saveAndFlush(currentTag);
            }

            tags.add(currentTag);
        }
        return tags;
    }

    private boolean isUserAuthorOrAdmin(Article article){
        UserDetails user=(UserDetails)SecurityContextHolder.getContext().getAuthentication().getPrincipal();
        User userEntity=this.userRepository.findByEmail(user.getUsername());

        return userEntity.isAdmin()|| userEntity.isAuthor(article);

    }

}
