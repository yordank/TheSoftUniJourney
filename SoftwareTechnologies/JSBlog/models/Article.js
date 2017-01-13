/**
 * Created by ADMIN on 15.11.2016 г..
 */
const mongoose=require('mongoose');
let articleScheme=mongoose.Schema(
    {
        title: {type: String, required: true},
        content: {type: String, required: true},
        author:{type:mongoose.Schema.Types.ObjectId,required:true,ref:'User'},
        category:{type:mongoose.Schema.Types.ObjectId,required:true,ref:'Category'},
        tags:[{type:mongoose.Schema.Types.ObjectId,required:true,ref:'Tag'}],
        date:{type:Date,default:Date.now()}
    }
);

articleScheme.method({
    prepareInsert:function () {
        let User=mongoose.model('User');
        User.findById(this.author).then(user=>{
            user.articles.push(this.id);
            user.save();
        });

        let Category=mongoose.model('Category');
        Category.findById(this.category).then(category=>{
            if(category)
            {
                category.article.push(this.id);
                category.save();
            }
        });

        let Tag=mongoose.model('Tag');
        for(let tagId of this.tags){
            Tag.findById(tagId).then(tag=>{
                if(tag)
                {
                    tag.articles.push(this.id);
                    tag.save();
                }
            });
        }

    },
    prepareDelete:function () {
        let User=mongoose.model('User');
        User.findById(this.author).then(user=>{
            if(user)
            {
                user.articles.remove(this.id);
                user.save();
            }
        })

        let Category=mongoose.model('Category');


        Category.findById(this.category).then(category=>{
            if(category){
                category.article.remove(this.id);
                category.save();
            }
        });


        let Tag=mongoose.model('Tag');
        for(let tagId of this.tags)
        {
            Tag.findById(tagId).then(tag=>{
                if(tag){
                    tag.articles.remove(this.id);
                    tag.save();
                }
            });
        }


    }
})



 const Article=mongoose.model('Article',articleScheme);

 module.exports = Article;