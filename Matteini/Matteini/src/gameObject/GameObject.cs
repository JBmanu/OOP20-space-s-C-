using Matteini.gameObject.utils;

namespace Matteini.gameObject
{
    public abstract class GameObject
    {
        protected GameObject(EngineImage engineImage, P2d position, IBoundingBox bb, IEventComponent eventComponent)
        {
            MainAnimation = new Animation(engineImage);
            EffectAnimation = new Animation(engineImage);
            BoundingBox = bb;
            EventComponent = eventComponent;
            Transform = new AffineTransform();
        }

        public AffineTransform Transform { get; set; }
        public IBoundingBox BoundingBox { get; set; }
        public IEventComponent EventComponent { get; set; }
        public Animation MainAnimation { get; set; }
        public Animation EffectAnimation { get; set; }
    }
}