/**
 * Created by ADMIN on 25.1.2017 г..
 */
function crystals(input){

    for(let i=1;i<input.length;i++) {
        let target=Number(input[0])
        let current=Number(input[i]);
        let prev=current;

        console.log(`Processing chunk ${current} microns`);

        current = cut(target, current, 'Cut');

            console.log('Transporting and washing');
        current=Math.floor(current);
        prev=current;

        if(current>target) {

            current = cut(target, current, 'Lap');
            if(prev!=current) {
                console.log('Transporting and washing');
                current = Math.floor(current);
                prev=current;
            }

        }

        if(current>target) {

            current = cut(target, current, 'Grind');
            if(prev!=current) {
                console.log('Transporting and washing');
                current = Math.floor(current);
                prev=current;
            }

        }

        if(current>target) {

            current = cut(target, current, 'Etch');
            if(prev!=current) {
                console.log('Transporting and washing');
                current = Math.floor(current);
                prev=current;
            }

        }



        if(current==target-1)
        {
            current++;
            console.log('X-ray x1');
        }



        console.log(`Finished crystal ${Math.floor(current)} microns`)

    }
    function cut(target,current,op) {

        let count=0;

        while (current >= target) {

            count++;

            switch (op){
                case 'Cut':current *= 0.25;break;
                case 'Lap':current *=0.8;break;
                case 'Grind':current =current-20;break;
                case 'Etch':current-=2;break;
            }


        }

        if(current+1!=target ) {
            switch (op){
                case 'Cut':current *=1/ 0.25;break;
                case 'Lap':current *=1/0.8;break;
                case 'Grind':current =current+20;break;
                case 'Etch':current+=2;break;
            }
        }


        if(op=='Etch' && current+1==target)
            count++;

        if(count>=2)
            console.log(`${op} x${count-1}`);

        return current;

    }





}

//crystals(['1375','50000'])
//crystals(['1000','4000','8100'])
crystals(['100', '101.9', '102'])