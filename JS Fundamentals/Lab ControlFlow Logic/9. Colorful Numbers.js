/**
 * Created by ADMIN on 17.1.2017 г..
 */
function ColorfulNumbers([num]){

    console.log('<ul>')
    for(let i=1;i<=num;i++){
        if(i%2==1)
            console.log("   <li><span style='color:green'>"+i+"</span></li>");
        else
            console.log("   <li><span style='color:blue'>"+i+"</span></li>");

    }
    console.log('</ul>')

}
