/**
 * Created by ADMIN on 26.1.2017 г..
 */
function sortArrayBy2Criteria(array){

    console.log(array.sort(function(x,y){
         if(x.length<y.length)
             return -1;
        if(x.length==y.length)
        {
            return (x<y?-1:(x>y?1:0));


        }
        else
            return 1;
    }).join('\n'))

}

//sortArrayBy2Criteria(['xxxxx','alpha','beta','gamma'])