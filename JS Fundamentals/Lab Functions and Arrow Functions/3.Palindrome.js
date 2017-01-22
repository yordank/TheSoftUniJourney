/**
 * Created by ADMIN on 22.1.2017 г..
 */
function palindrom([str]){

    let func=(function reverse(string)
    {
         for(let i=0;i<string.length;i++){
             if(string[i]!=string[string.length-1-i])
                 return false;
         }
         return true;
    });
    console.log(func(str));
}

