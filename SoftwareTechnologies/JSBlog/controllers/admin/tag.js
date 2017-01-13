/**
 * Created by ADMIN on 25.11.2016 г..
 */
const Tag=require('mongoose').model('Tag');
const Article=require('mongoose').model('Article');

module.exports={
    listArticlesByTag:(req,res)=>{

        let name=req.params.name;
        Tag.findOne({name:name}).then(tag=>{
            Article.find({tags:tag.id}).populate('author tags')
                .then(articles=>{
                    res.render('tag/details',{articles:articles,tag:tag});
               })

        })
    }
}