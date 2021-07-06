namespace Matteini.gameObject.utils
{
    public interface IBoundingBox
    {
        AffineTransform GetTransform();
        
        void SetTransform(AffineTransform transform);
    }
}