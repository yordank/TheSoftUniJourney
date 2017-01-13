package softuniBlog.entity;

import javax.persistence.*;
import java.util.HashSet;
import java.util.Set;

/**
 * Created by ADMIN on 1.12.2016 г..
 */

@Entity
@Table(name="categories")
public class Category {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    public Integer getId() {
        return id;
    }

    public void setId(Integer id) {
        this.id = id;
    }

    @Column(nullable = false,unique = true)
    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    @OneToMany(mappedBy = "category")
    public Set<Article> getArticles() {
        return articles;
    }

    public void setArticles(Set<Article> articles) {
        this.articles = articles;
    }

    private Integer id;
    private String name;
    private Set<Article> articles;


    public Category(){}
    public Category(String name){
        this.name=name;
        this.articles=new HashSet<>();
    }
}
