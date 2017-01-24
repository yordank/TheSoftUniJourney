/**
 * Created by ADMIN on 24.1.2017 г..
 */
function Rocket([n]){

    n=Number(n);

    let line='';

    for(let i=0;i<n;i++){

        line='.'.repeat((3*n-2)/2-i);
        line+='/';
        line+=' '.repeat(2*i);
        line+=`\\`;
        line+='.'.repeat((3*n-2)/2-i);
        console.log(line);
        line='';

    }

    line='.'.repeat((3*n-2)/2-n+1);
    line+='*'.repeat(2*(n-1)+2);
    line+='.'.repeat((3*n-2)/2-n+1);
    console.log(line);

    for(let j=0;j<2*n;j++){

        line='.'.repeat((3*n-2)/2-n+1);
        line+='|';
        line+='\\'.repeat(2*(n-1));
        line+='|';
        line+='.'.repeat((3*n-2)/2-n+1);
        console.log(line);

    }

    for(let j=0;j<n/2;j++){

        line='.'.repeat((3*n-2)/2-n+1-j);
        line+='/';
        line+='*'.repeat(2*(n-1)+2*j);
        line+='\\';
        line+='.'.repeat((3*n-2)/2-n+1-j);
        console.log(line);

    }


}
//Rocket(['8'])