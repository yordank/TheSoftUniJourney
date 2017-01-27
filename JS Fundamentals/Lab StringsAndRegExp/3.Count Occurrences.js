/**
 * Created by ADMIN on 27.1.2017 г..
 */
function countOccurrences([text,input]){

    let ind=-1;
    let count=0;

    while((ind=input.indexOf(text,ind+1))!=-1)
    {
        count++;
    }

    console.log(count);
}
//countOccurrences(['ma', 'Marine mammal training is the training and caring for marine life such as, dolphins, killer whales, sea lions, walruses, and other marine mammals. It is also a duty of the trainer to do mental and physical exercises to keep the animal healthy and happy.'])