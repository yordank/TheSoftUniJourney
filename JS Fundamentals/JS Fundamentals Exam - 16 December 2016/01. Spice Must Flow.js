/**
 * Created by ADMIN on 3.2.2017 г..
 */
function spice([startingSpices]){

    let currentSpices=Number(startingSpices);
    let sum=0;
    let days=0;
    while(currentSpices>=100)
    {
        sum+=currentSpices-26;
        currentSpices-=10;
        days++;
    }
    sum-=26;
    sum=(sum<0)?0:sum;
    console.log(days)
    console.log(sum);

}

//spice(['111'])
//spice(['450'])
//spice(['9'])