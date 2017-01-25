/**
 * Created by ADMIN on 25.1.2017 г..
 */
function trip([x1,y1,x2,y2,x3,y3]){

    [x1,y1,x2,y2,x3,y3]=[x1,y1,x2,y2,x3,y3].map(Number);
    let dist=0;
    let output='';

    if(dist<distance(x1,y1,x2,y2,x3,y3)){

        dist=distance(x1,y1,x2,y2,x3,y3);

        output='1->2->3: '+dist;

    }


    if(dist>distance(x1,y1,x3,y3,x2,y2)){

        dist=distance(x1,y1,x3,y3,x2,y2);

        output='1->3->2: '+dist;

    }


    if(dist>distance(x2,y2,x1,y1,x3,y3)){

        dist=distance(x2,y2,x1,y1,x3,y3);

        output='2->1->3: '+dist;

    }

    if(dist>distance(x2,y2,x3,y3,x1,y1)){

        dist=distance(x2,y2,x3,y3,x1,y1);

        output='2->3->1: '+dist;

    }


    if(dist>distance(x3,y3,x1,y1,x2,y2)){

        dist=distance(x3,y3,x1,y1,x2,y2);

        output='3->1->2: '+dist;

    }


    if(dist>distance(x3,y3,x2,y2,x1,y1)){

        dist=distance(x3,y3,x2,y2,x1,y1);

        output='3->2->1: '+dist;

    }

    console.log(output);



    function distance(x1,y1,x2,y2,x3,y3){

        let distance=Math.sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2))+Math.sqrt((x2-x3)*(x2-x3)+(y2-y3)*(y2-y3));
        return distance;

    }

}

//trip(['-1', '-2', '3.5', '0', '0', '2'])