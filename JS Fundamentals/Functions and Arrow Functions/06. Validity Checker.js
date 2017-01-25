/**
 * Created by ADMIN on 25.1.2017 г..
 */
function validityChecker([x1,y1,x2,y2]){


    print(x1,y1,0,0);
    print(x2,y2,0,0);
    print(x1,y1,x2,y2);

    function print(x1,y1,x2,y2){

        console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is ${check(x1,y1,x2,y2)?'valid':'invalid'}`);

    }

    function check(x1,y1,x2,y2) {
        let distance=Math.sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
        if(distance === parseInt(distance, 10))
            return true;
        return false
    }

}

//validityChecker(['2','1','1','1'])