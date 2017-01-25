/**
 * Created by ADMIN on 25.1.2017 г..
 */
function DNA([num]){

    let str='ATCGTTAGGG';


    let step=2;
    let count=-2;

    for (let i = 0; i <Number(num)*2; i=i+2) {

       let letter1 = str[i%str.length];

       let letter2 = str[(i+1)%str.length];

       if(count==4)
       {
           step=-2;
       }

       if(count==0)
       {
           step=2;
       }

       count=count+step;


        let line='*'.repeat((6-count-1)/2) + letter1+'-'.repeat(count)+letter2+'*'.repeat((6-count-1)/2);
        console.log(line);


    }

}

//DNA(['50'])