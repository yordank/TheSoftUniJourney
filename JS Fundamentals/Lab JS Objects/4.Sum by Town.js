/**
 * Created by ADMIN on 30.1.2017 г..
 */
function sumByTown(inputArr){

    let result={};

    for(let i=0;i<inputArr.length;i+=2){

        if(result[inputArr[i]])
        result[inputArr[i]]+=Number(inputArr[i+1]);
        else
        result[inputArr[i]]=Number(inputArr[i+1]);

    }

   console.log(JSON.stringify(result))


}

//sumByTown(['Sofia','20','Varna','3','Sofia','5','Varna','4'])