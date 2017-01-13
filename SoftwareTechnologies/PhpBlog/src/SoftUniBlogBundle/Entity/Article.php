<?php

namespace SoftUniBlogBundle\Entity;

use Doctrine\Common\Collections\ArrayCollection;

use Doctrine\ORM\Mapping as ORM;

/**
 * Article
 *
 * @ORM\Table(name="articles")
 * @ORM\Entity(repositoryClass="SoftUniBlogBundle\Repository\ArticleRepository")
 */
class Article
{


    /**
     * @var Category
     * @ORM\ManyToOne(targetEntity="SoftUniBlogBundle\Entity\Category",inversedBy="articles")
     * @ORM\JoinColumn(name="category_id",referencedColumnName="id")
     */

    private $category;

    /**
     * @var int
     *
     * @ORM\Column(name="id", type="integer")
     * @ORM\Id
     * @ORM\GeneratedValue(strategy="AUTO")
     */
    private $id;

    /**
     * @var int
     *
     * @ORM\Column(name="category_id",type="integer")
     */

    private $categoryId;
    /**
     * @var string
     *
     * @ORM\Column(name="title", type="string", length=255)
     */
    private $title;

    /**
     * @var string
     *
     * @ORM\Column(name="content", type="text")
     */
    private $content;

    /**
     * @var \DateTime
     *
     * @ORM\Column(name="dateAdded", type="datetime")
     */
    private $dateAdded;

    /**
     * @var string
     */
    private $summary;

    /**
     * @var int
     *
     * @ORM\Column(name="authorId",type="integer")
     */
    private $authorId;

    /**
     * @var User
     *
     * @ORM\ManyToOne(targetEntity="SoftUniBlogBundle\Entity\User",inversedBy="articles")
     * @ORM\JoinColumn(name="authorId",referencedColumnName="id")
     */
    private $author;

    /**
     * @var ArrayCollection
     * @ORM\ManyToMany(targetEntity="SoftUniBlogBundle\Entity\Tag", inversedBy="articles")
     * @ORM\JoinTable(name="article_tags",
     *     joinColumns={@ORM\JoinColumn(name="article_id",referencedColumnName="id")},
     *     inverseJoinColumns={@ORM\JoinColumn(name="tag_id",referencedColumnName="id")}
     *     )
     */
    private $tags;

    /**
     * @return ArrayCollection
     */

    public function getTags()
    {
        return $this->tags;
    }

    /**
     * @param ArrayCollection $tags
     */
    public function setTags($tags)
    {
        $this->tags=$tags;
    }


    public function  __construct()
    {
        $this->dateAdded=new \DateTime('now');
        $this->tags=new ArrayCollection();
    }


    /**
     * @return \SoftUniBlogBundle\Entity\User
     */
    public function getAuthor()
    {
        return $this->author;
    }

    /**
     * @param \SoftUniBlogBundle\Entity\User $author
     * @return Article
     */
    public function setAuthor(User $author=null)
    {
        $this->author = $author;
        return $this;
    }

    /**
     * @return int
     */
    public function getAuthorId(): int
    {
        return $this->authorId;
    }


    /**
     * @param integer $authorId
     * @return Article
     */
    public function setAuthorId(int $authorId)
    {
        $this->authorId = $authorId;

        return $this;
    }

    /**
     * @param string
     */
    public function setSummary()
    {
        $this->summary = substr($this ->getContent(),0,strlen($this ->getContent())/2)."...";
    }

    /**
     * @return string
     */
    public function getSummary()
    {
        if($this ->summary===null)
        {
           $this ->setSummary();
        }
        return $this->summary;
    }

    /**
     * Get id
     *
     * @return int
     */
    public function getId()
    {
        return $this->id;
    }

    /**
     * Set title
     *
     * @param string $title
     *
     * @return Article
     */
    public function setTitle($title)
    {
        $this->title = $title;

        return $this;
    }

    /**
     * Get title
     *
     * @return string
     */
    public function getTitle()
    {
        return $this->title;
    }

    /**
     * Set content
     *
     * @param string $content
     *
     * @return Article
     */
    public function setContent($content)
    {
        $this->content = $content;

        return $this;
    }

    /**
     * Get content
     *
     * @return string
     */
    public function getContent()
    {
        return $this->content;
    }

    /**
     * Set dateAdded
     *
     * @param \DateTime $dateAdded
     *
     * @return Article
     */
    public function setDateAdded($dateAdded)
    {
        $this->dateAdded = $dateAdded;

        return $this;
    }

    /**
     * Get dateAdded
     *
     * @return \DateTime
     */
    public function getDateAdded()
    {
        return $this->dateAdded;
    }


    /**
     * @return int
     */
    public function getCategoryId():int
    {
        return $this->categoryId;
    }

    /**
     * @param int $categoryId
     */
    public function setCategoryId(int $categoryId)
    {
        $this->categoryId=$categoryId;
    }

    /**
     * @return Category
     */
    public function getCategory()
    {
        return $this->category;
    }

    /**
     * @param Category $category
     */
    public function setCategory(Category $category)
    {
        $this->category=$category;
    }

}

