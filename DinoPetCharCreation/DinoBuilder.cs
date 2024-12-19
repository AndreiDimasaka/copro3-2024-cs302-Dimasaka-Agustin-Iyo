using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DinoPetCharCreation;

public abstract class DinoBuilder
{
    public abstract string Era { get; set; }

    public abstract string Habitat{get;set;}
    public abstract string Breed{get;set;}
    public abstract string Gender{get;set;}
    public abstract string Nature{get;set;}
    public abstract string SkinColor{get;set;}
    public abstract string SkinPattern{get;set;}
    public abstract string SkinTexture{get;set;}
    public abstract string FavoriteFood{get;set;}
    public abstract string BodyFeatures{get;set;}
    public abstract string FacialFeatures{get;set;}
    public abstract string TailType{get;set;}
    public abstract string Behavior{get;set;}
    public abstract string Name { get; set; }

}
public interface DinoBuild
{
    void TraitsAmount();
    bool hasWing();
    bool hasFins();
    bool hasClaw();
    
}