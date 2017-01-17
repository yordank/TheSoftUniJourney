/**
 * Created by ADMIN on 17.1.2017 г..
 */
function cone([radius,height]){

    let l=Math.sqrt(Number(radius*radius)+Number(height*height));
    console.log('volume = '+ Math.PI*radius*radius*height/3);
    console.log('area = '+Number(Math.PI*radius*l+Math.PI*radius*radius));

}

