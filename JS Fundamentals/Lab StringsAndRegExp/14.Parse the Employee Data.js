/**
 * Created by ADMIN on 27.1.2017 г..
 */
function parseEmployeeData(input){

    let pattern=/^([A-Z][a-zA-Z]*) - ([1-9][0-9]*) - ([a-zA-Z0-9 -]+)$/;


    for(let item of input){
        let match=pattern.exec(item);
        if(match){

            console.log('Name: '+match[1]);
            console.log('Position: '+match[3]);
            console.log('Salary: '+match[2]);
        }

    }

}
/*
parseEmployeeData(['Isacc - 1000 - CEO',
    'Ivan - 500 - Employee',
    'Peter - 500 - Employee'
])
*/
