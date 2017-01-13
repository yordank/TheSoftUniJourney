/**
 * Created by ADMIN on 22.11.2016 г..
 */
const mongoose=require('mongoose');

let categoryScheme=mongoose.Schema({
    name:{type:String,require:true,unique:true},
    article:[{type:mongoose.Schema.Types.ObjectId,ref:'Article'}]
});

categoryScheme.method({
    prepareDelete:function () {
        let Article=mongoose.model('Article');
        for(let article of this.article)
        {
            Article.findById(article).then(article=>{
                article.prepareDelete();
                article.remove();
            })
        }
    }
})

categoryScheme.set('versionKey',false);
const Category=mongoose.model('Category',categoryScheme);