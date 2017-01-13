<?php

namespace SoftUniBlogBundle\Controller;

use SoftUniBlogBundle\Entity\Tag;
use Symfony\Bundle\FrameworkBundle\Controller\Controller;
use Sensio\Bundle\FrameworkExtraBundle\Configuration\Route;

class TagController extends Controller
{

    /**
     * @Route("/tags/{name}",name="articles_with_tag")
     * @param $name
     * @return \Symfony\Component\HttpFoundation\Response
     */
    public function articles($name)
    {
        $tag=$this->getDoctrine()->getRepository(Tag::class)->findOneBy(['name'=>$name]);

        return $this->render('tag/articles.html.twig',['tag'=>$tag]);

    }
}
