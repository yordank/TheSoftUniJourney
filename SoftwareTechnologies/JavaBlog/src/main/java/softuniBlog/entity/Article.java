package softuniBlog.entity;

/**
 * Created by ADMIN on 27.11.2016 г..
 */

import javax.persistence.*;
import java.util.HashSet;
import java.util.Set;

@Entity
@Table(name="articles")
public class Article {
    private Integer id;
    private String title;
    private String content;
    private User author;
    private Category category;
    private Set<Tag> tags;

    @ManyToMany()
    @JoinColumn(table="articles_tags")
    public Set<Tag> getTags() {
        return tags;
    }

    public void setTags(Set<Tag> tags) {
        this.tags = tags;
    }



    @ManyToOne
    @JoinColumn(nullable = false,name="categoryId")
    public Category getCategory() {
        return category;
    }

    public void setCategory(Category category) {
        this.category = category;
    }

    public Article(String title, String content, User author, Category category, HashSet<Tag>tags)
    {
        this.title=title;
        this.content=content;
        this.author=author;
        this.category=category;
        this.tags=tags;
    }
    public Article(){

    }

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    public Integer getId() {
        return id;
    }

    public void setId(Integer id) {
        this.id = id;
    }

    @Column(nullable = false)
    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    @Column(columnDefinition = "text",nullable = false)
    public String getContent() {
        return content;
    }

    public void setContent(String content) {
        this.content = content;
    }

    @ManyToOne()
    @JoinColumn(nullable = false,name="authorId")
    public User getAuthor() {
        return author;
    }

    public void setAuthor(User author) {
        this.author = author;
    }

    @Transient
    public String getSummary(){
        return this.getContent().substring(0,this.getContent().length()/2)+" ...";
    }

}

