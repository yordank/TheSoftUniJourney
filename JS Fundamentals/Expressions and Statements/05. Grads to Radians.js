/**
 * Created by ADMIN on 19.1.2017 г..
 */
function GradsToRadians([grad]){


    grad=Number(grad)%400;
    if(grad<0)
        grad=grad+400;
    grad=grad/400;
    console.log(grad*360)


}

