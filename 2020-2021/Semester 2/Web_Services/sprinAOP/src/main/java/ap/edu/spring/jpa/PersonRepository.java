package ap.edu.spring.jpa;

import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;

import ap.edu.spring.aop.Interceptable;

@Repository
public interface PersonRepository extends CrudRepository<Person, Long> {
    
    @Interceptable
    public Person findByName(String name);
}