/**
 * Created by ADMIN on 25.1.2017 г..
 */
function solve(input){

    for(let i=0;i<input.length;i=i+3) {
        let x = Number(input[i]);
        let y = Number(input[i+1]);
        let z = Number(input[i+2]);

        if (InVolume(x, y, z))
            console.log('inside');
        else
            console.log('outside');
    }
    function InVolume(x,y,z){

        let x1=10,x2=50;
        let y1=20,y2=80;
        let z1=15,z2=50;

            if(x>=x1 && x<=x2)
                if(y>=y1 && y<=y2)
                    if(z>=z1 && z<=z2)
                        return true;
        return false;
    }
}