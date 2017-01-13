package softuniBlog.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import softuniBlog.entity.Tag;

/**
 * Created by ADMIN on 1.12.2016 г..
 */
public interface TagRepository extends JpaRepository<Tag,Integer> {
    Tag findByname(String name);
}
