/**
 * Created by ADMIN on 14.1.2017 г..
 */
function DistanceBetweenPoints([x1,y1,x2,y2])
{

    let Point1={x:Number(x1),y:Number(y1)};
    let Point2={x:Number(x2),y:Number(y2)};

    console.log(Math.sqrt((Point1.x-Point2.x)*(Point1.x-Point2.x)+(Point1.y-Point2.y)*(Point1.y-Point2.y)));

}


