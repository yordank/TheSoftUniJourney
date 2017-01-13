const mongoose=require('mongoose');

let roleScheme=mongoose.Schema({
    name:{type:String ,require:true,unique:true},
    users:[{type:mongoose.Schema.Types.ObjectId,ref:'User'}]
});

const Role=mongoose.model('Role',roleScheme);

module.exports=Role;

module.exports.initialize=()=>{
    Role.findOne({name:'User'}).then(role=>{
        if(!role)
        {
            Role.create({name:'User'});
        }
    });

    Role.findOne({name:'Admin'}).then(role=>{
        if(!role)
        {
            Role.create({name:'Admin'});
        }
    });

}