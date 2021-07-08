using Paganelli.model.utility;

namespace Paganelli.controller
{
    
    /**
    * Caller command for the ship.
    */
    public class CallerCommandShip
    {
        private readonly ICommandShip _cmdUp;
        private readonly ICommandShip _cmdReleaseUp;
        private readonly ICommandShip _cmdRotateLeft;
        private readonly ICommandShip _cmdRotateRight;
        private readonly ICommandShip _cmdShot;

        private readonly SpaceShip _ship;
        
        /** 
        * Constructor for CallerCommand, initialize a new CallerCommand for the spaceship.
        * 
        * @param ship ship on which to execute the commands.
        */
        public CallerCommandShip(SpaceShip ship)
        {
            this._cmdUp = new Up();
            this._cmdReleaseUp = new UpRelease();
            this._cmdRotateLeft = new RotateLeft();
            this._cmdRotateRight = new RotateRight();
            this._cmdShot = new Fire();
            this._ship = ship;
        }

        /** 
        * Read the passed command and execute the command on the specified concrete command.
        * 
        * @param cmd the command to execute
        */
        public void Execute(CommandKey cmd)
        {

            if (cmd.Equals(CommandKey.KEY_UP_PRESSED))
            {
                _cmdUp.Execute(_ship);
            }
            else if (cmd.Equals(CommandKey.KEY_UP_RELEASED))
            {
                _cmdReleaseUp.Execute(_ship);
            }
            else if (cmd.Equals(CommandKey.KEY_W_PRESSED))
            {
                _cmdUp.Execute(_ship);
            }
            else if (cmd.Equals(CommandKey.KEY_W_RELEASED))
            {
                _cmdReleaseUp.Execute(_ship);
            }
            else if (cmd.Equals(CommandKey.KEY_LEFT))
            {
                _cmdRotateLeft.Execute(_ship);
            }
            else if (cmd.Equals(CommandKey.KEY_A))
            {
                _cmdRotateLeft.Execute(_ship);
            }
            else if (cmd.Equals(CommandKey.KEY_RIGHT))
            {
                _cmdRotateRight.Execute(_ship);
            }
            else if (cmd.Equals(CommandKey.KEY_D))
            {
                _cmdRotateRight.Execute(_ship);
            }
            else if (cmd.Equals(CommandKey.KEY_SPACE_BAR))
            {
                _cmdShot.Execute(_ship);
            }
            else if (cmd.Equals(CommandKey.KEY_K))
            {
                _cmdShot.Execute(_ship);
            }
        }

    }

}
