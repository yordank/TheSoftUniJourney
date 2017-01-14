/**
 * Created by ADMIN on 14.1.2017 г..
 */
function FilterByAge([minAge,name1,age1,name2,age2]){

    let Person1={name:name1,age:Number(age1)};
    let Person2={name:name2,age:Number(age2)};

    if(Person1.age>=Number(minAge))
        console.log(Person1)
    if(Person2.age>=Number(minAge))
        console.log(Person2);

}

