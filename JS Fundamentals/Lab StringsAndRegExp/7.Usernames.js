/**
 * Created by ADMIN on 27.1.2017 г..
 */
function usernames(input){

    let result=[];

    for(let items of input){

        let item=items.split('@');

        let letters=item[1].split('.')

        result.push(item[0]+'.'+letters.map(x=>x[0]).join(''))
    }

    console.log(result.join(', '))

}
//usernames(['peshoo@gmail.com', 'todor_43@mail.dir.bg', 'foo@bar.com'])