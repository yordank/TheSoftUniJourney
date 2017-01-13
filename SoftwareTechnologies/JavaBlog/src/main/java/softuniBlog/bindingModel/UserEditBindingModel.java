package softuniBlog.bindingModel;

import java.util.ArrayList;
import java.util.List;

/**
 * Created by ADMIN on 28.11.2016 г..
 */
public class UserEditBindingModel extends UserBindingModel {

    public List<Integer> getRoles() {
        return roles;
    }

    public void setRoles(List<Integer> roles) {
        this.roles = roles;
    }

    private List<Integer> roles;
    public UserEditBindingModel(){this.roles=new ArrayList<>();}
}
