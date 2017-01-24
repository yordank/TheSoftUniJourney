/**
 * Created by ADMIN on 24.1.2017 г..
 */
function logistic(arr){

    let sum=0;
    let count=0;
    let microbus=0;
    let truck=0;
    let train=0;

    for(let i=1;i<arr.length;i++){
        if(arr[i]<=3)
        {
            sum+=200*Number(arr[i]);
            microbus+=Number(arr[i]);
            count+=Number(arr[i]);
        }
        if(arr[i]<=11 && arr[i]>=4)
        {
            sum+=175*Number(arr[i]);
            truck+=Number(arr[i]);
            count+=Number(arr[i]);
        }
        if(arr[i]>11)
        {
            sum+=120*Number(arr[i]);
            train+=Number(arr[i]);
            count+=Number(arr[i]);
        }
    }

    console.log((sum/count).toFixed(2));
    console.log((100*microbus/count).toFixed(2)+'%');
    console.log((100*truck/count).toFixed(2)+'%');
    console.log((100*train/count).toFixed(2)+'%');

}

//logistic(['4','1','5','16','3'])