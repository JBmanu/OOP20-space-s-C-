namespace Matteini.gameObject.utils
{
    public class RectBoundingBox : IBoundingBox
    {
        private readonly AffineTransform _transform;

        public RectBoundingBox(AffineTransform transform)
        {
            this._transform = transform;
        }

        public AffineTransform GetTransform()
        {
            return this._transform;
        }

        public void SetTransform(AffineTransform transform)
        {
        }
    }
}