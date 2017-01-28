/**
 * Created by ADMIN on 28.1.2017 г..
 */
function capitalize([text]){

    console.log(text.split(' ').
            map(x=>x[0].
                toUpperCase() +
                x.slice(1,x.length).
                split('').
                map(y=>y.toLowerCase()).
                join('')
               ).
            join(' '))

}

//capitalize(['Capitalize these words'])
//capitalize(['Was That Easy? Try This One For Size!'])