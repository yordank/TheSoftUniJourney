/**
 * Created by ADMIN on 22.1.2017 г..
 */
function triangleOfStars([num]){

    let n=Number(num);


    for(let i=1;i<=n;i++)
        console.log('*'.repeat(i));

    for(let j=n-1;j>=1;j--)
        console.log('*'.repeat(j));



}

