/**
 * Created by ADMIN on 27.1.2017 г..
 */
function emailValidation([input]){

       let pattern =/^[a-zA-Z0-9]+\@[a-z]+(\.[a-z]+)+$/g;
        let result = pattern.test(input);
        if (result) {
            console.log("Valid");
        }
        else {
            console.log("Invalid");
        }



}

//emailValidation(['valid@email.bg'])