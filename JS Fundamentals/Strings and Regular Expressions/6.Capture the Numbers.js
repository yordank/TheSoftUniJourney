/**
 * Created by ADMIN on 28.1.2017 г..
 */
function capture(input){

    let pattern=/\d+/g;
    let result=[];
    let match;

    for(let item of input){
        match=pattern.exec(item);
        while(match){
            result.push(match[0]);
            match=pattern.exec(item);
        }

    }
    console.log(result.join(' '))

}

//capture(['The300','What is that? I think it’s the 3rd movie.Lets watch it at 22:45'])