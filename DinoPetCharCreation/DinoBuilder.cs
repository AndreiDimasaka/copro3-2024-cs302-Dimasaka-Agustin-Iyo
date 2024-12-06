using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DinoPetCharCreation;

public abstract class DinoBuilder
{
    public abstract string Era { get; set; }

    public abstract string Habitat();
    public abstract string Breed();
    public abstract string Gender();
    public abstract string Nature();
    public abstract string SkinColor(string color);
    public abstract string SkinPattern();
    public abstract string SkinTexture();
    public abstract string FavoriteFood();
    public abstract string BodyFeatures();
    public abstract string FacialFeatures();
    public abstract string TailType();
    public abstract string Behavior();
    public abstract string Name { get; set; }

}
public interface DinoBuild
{
    void TraitsAmount();
    void PrintTraits();
    bool hasWing();
    bool hasFins();
    bool hasClaw();
    
}
