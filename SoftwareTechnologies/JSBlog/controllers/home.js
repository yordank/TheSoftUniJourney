const mongoose=require('mongoose');
const Article=mongoose.model('Article');
const User=mongoose.model('User');
const Category=mongoose.model('Category');
const Tag=mongoose.model('Tag');

module.exports = {
  index: (req, res) => {
      Category.find({}).then(categories=>{
          res.render('home/index',{categories: categories});
      })

  },

    listCategoryArticles:(req,res)=> {
        let id=req.params.id;
        Category.findById(id).populate('article').then(category=>{
            User.populate(category.article,{path: 'author'},(err)=>{
                if(err)
                {
                    console.log(err.message);
                }

                Tag.populate(category.article,{path:'tags'},(err)=>{
                    if(err)
                    {
                        console.log(err.message);
                    }

                    res.render('home/article',{articles:category.article})

                })



            });



        });
    }
};