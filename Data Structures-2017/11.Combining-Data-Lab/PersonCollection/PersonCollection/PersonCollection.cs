using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Wintellect.PowerCollections;

public class PersonCollection : IPersonCollection
{
    private Dictionary<string, Person> personsByEmail = new Dictionary<string, Person>();
    private Dictionary<string, SortedSet<Person>> personsByEmailDomain = new Dictionary<string, SortedSet<Person>>();
    private Dictionary<string, SortedSet<Person>> personsByNameAndTown = new Dictionary<string, SortedSet<Person>>();
    private OrderedDictionary<int, SortedSet<Person>> personsByAge = new OrderedDictionary<int, SortedSet<Person>>();
    private Dictionary<string, OrderedDictionary<int, SortedSet<Person>>> personsByTownAndAge = new Dictionary<string, OrderedDictionary<int, SortedSet<Person>>>();

    // TODO: define the underlying data structures here ...

    public bool AddPerson(string email, string name, int age, string town)
    {
        if(this.FindPerson(email)!=null)
        {
            return false;
        }

        var person = new Person()
        {
            Email = email,
            Name = name,
            Age = age,
            Town = town
        };

        this.personsByEmail.Add(email, person);


        var emailDomain = this.ExtractEmailDomain(email);

        if (!personsByEmailDomain.ContainsKey(emailDomain))
        {
            var newSet = new SortedSet<Person>();

            newSet.Add(person);

            this.personsByEmailDomain.Add(emailDomain, newSet);
        }
        else
        {
            this.personsByEmailDomain[emailDomain].Add(person);
        }


        var nameAndTown = this.CombineNameAndTown(name, town);

        if (!personsByNameAndTown.ContainsKey(nameAndTown))
        {
            var newSet = new SortedSet<Person>();

            newSet.Add(person);

            this.personsByNameAndTown.Add(nameAndTown, newSet);
        }
        else
        {
            this.personsByNameAndTown[nameAndTown].Add(person);
        }

        if (!personsByAge.ContainsKey(age))
        {
            var newSet = new SortedSet<Person>();

            newSet.Add(person);

            this.personsByAge.Add(age, newSet);

        }
        else
        {
            this.personsByAge[age].Add(person);
        }


        this.personsByTownAndAge.EnsureKeyExists(town);

        if (!personsByTownAndAge[town].ContainsKey(age))
        {
            var newSet = new SortedSet<Person>();

            newSet.Add(person);

            this.personsByTownAndAge[town].Add(age, newSet);

        }
        else
        {
            this.personsByTownAndAge[town][age].Add(person);
        }


        return true;

    }

    private string ExtractEmailDomain(string email)
    {
        var domain = email.Split('@')[1];

        return domain;
    }

    public int Count
    {
        get
        {
            return this.personsByEmail.Count;
        }
    }

    public Person FindPerson(string email)
    {
        Person person;
        var personExists = this.personsByEmail.TryGetValue(email, out person);
        return person;
    }

    public bool DeletePerson(string email)
    {
        var person = this.FindPerson(email);

        if(person==null)
        {
            return false;
        }

        var personDeleted = this.personsByEmail.Remove(email);

        var emailDomain = this.ExtractEmailDomain(email);

        this.personsByEmailDomain[emailDomain].Remove(person);

        var nameAndTown = this.CombineNameAndTown(person.Name, person.Town);
        this.personsByNameAndTown[nameAndTown].Remove(person);

        this.personsByAge[person.Age].Remove(person);

        personsByTownAndAge[person.Town][person.Age].Remove(person);
        return true;
    }

    public IEnumerable<Person> FindPersons(string emailDomain)
    {
        return this.personsByEmailDomain.GetValuesForKey(emailDomain);
    }

    public IEnumerable<Person> FindPersons(string name, string town)
    {
        string nameAndTown=this.CombineNameAndTown(name,town);

        return this.personsByNameAndTown.GetValuesForKey(nameAndTown);

    }

    private string CombineNameAndTown(string name, string town)
    {
        const string separator = "|!|";

        return name + separator + town;

    }

    public IEnumerable<Person> FindPersons(int startAge, int endAge)
    {
        var personsInRange = this.personsByAge.Range(startAge, true, endAge, true);

        foreach (var personsByAge in personsInRange)
        {
            foreach (var person in personsByAge.Value)
            {
                yield return person;
            }
        }
    }

    public IEnumerable<Person> FindPersons(
        int startAge, int endAge, string town)
    {
        if(!this.personsByTownAndAge.ContainsKey(town))
        {
            yield break;
        }

        var personsInRange = this.personsByTownAndAge[town]
            .Range(startAge, true, endAge, true);

        foreach (var persons in personsInRange)
        {
            foreach (var item in persons.Value)
            {
                  yield return item;
            }
        }
    }
}
