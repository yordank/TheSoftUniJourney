/**
 * Created by ADMIN on 25.1.2017 г..
 */
function treasure(input){


    for(let i=0;i<input.length;i=i+2){
       console.log( islands(input[i],input[i+1]));
    }

    function islands(x,y){

        if(x<=3 && x>=1 && y>=1 && y<=3){
            return 'Tuvalu';
        }

        if(x<=9 && x>=8 && y>=0 && y<=1){
            return 'Tokelau';
        }

        if(x<=7 && x>=5 && y>=3 && y<=6){
            return 'Samoa';
        }


        if(x<=2 && x>=0 && y>=6 && y<=8){
            return 'Tonga';
        }

        if(x<=9 && x>=4 && y>=7 && y<=8){
            return 'Cook';
        }


        return 'On the bottom of the ocean';

    }


}

//treasure([4, 2, 1.5, 6.5, 1, 3])
