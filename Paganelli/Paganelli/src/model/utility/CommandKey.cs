using System.Collections.Generic;
using System.IO;
using Paganelli.model.utility;

namespace Paganelli.model.utility
{
 /**
 * Class for the command type, all available keys and their key codes.
 *
 */
 public class CommandKey
 {
  /**
     * Type of command to pass to the CallerCommand to rotate the spaceship left.
     */
  public static readonly CommandKey KEY_LEFT = new CommandKey(37, CommandType.PRESSED);

  /**
     * Type of command to pass to the CallerCommand to acelerate the spaceship.
     */

  public static CommandKey KEY_UP_PRESSED = new CommandKey(38, CommandType.PRESSED);

  /**
     * Type of command to pass to the CallerCommand to decelerate the spaceship.
     */
  public static CommandKey KEY_UP_RELEASED = new CommandKey(38, CommandType.RELEASED);

  /**
     * Type of command to pass to the CallerCommand to rotate the spaceship right.
     */
  public static CommandKey KEY_RIGHT = new CommandKey(39, CommandType.PRESSED);

  /**
     * Type of command to pass to the CallerAudio to let the spaceship shot.
     */
  public static CommandKey KEY_SPACE_BAR = new CommandKey(32, CommandType.PRESSED);

  /**
     * Type of command to pass to the CallerCommand to let the spaceship shot.
     */
  public static CommandKey KEY_K = new CommandKey(75, CommandType.PRESSED);

  /**
     * Type of command to pass to the CallerCommand to rotate the spaceship left.
     */
  public static CommandKey KEY_A = new CommandKey(65, CommandType.PRESSED);

  /**
     * Type of command to pass to the CallerCommand to acelerate the spaceship.
     */
  public static CommandKey KEY_W_PRESSED = new CommandKey(87, CommandType.PRESSED);

  /**
     * Type of command to pass to the CallerCommand to decelerate the spaceship.
     */
  public static CommandKey KEY_W_RELEASED = new CommandKey(87, CommandType.RELEASED);

  /**
     * Type of command to pass to the CallerCommand to rotate the spaceship right.
     */
  public static CommandKey KEY_D = new CommandKey(68, CommandType.PRESSED);

  /**
     * Code of the relative character.
     */
  private int keyCode;
  private CommandType type;

  /**
     * Constructor for create enum associating a key code.
     */
  private CommandKey(int keyCode, CommandType type)
  {
   this.keyCode = keyCode;
   this.type = type;
  }

  /**
     * Empty constructor for create an empty CommandKey.
     */
  public CommandKey()
  {
  }

  /**
     * Return an optional of CommandType from the passed value if present.
     * 
     * @param value int rapresenting the code of the key
     * @param type  CommandType rapresenting the type of the command
     * @return the specific CommanType or an empty optional 
     */
  public CommandKey getValue(int value, CommandType type)
  {
   CommandKey retVal = new CommandKey();
   Values().ForEach(val =>
   {
    if (val.GetType().Equals(type))
    {
     retVal = val;
    }
   });
   return retVal;
  }


  /**
     * Return the key code.
     * 
     * @return the specific key code
     */
  int getKeyCode()
  {
   return this.keyCode;
  }

  /**
     * Return the type.
     * 
     * @return the specific key code
     */
  CommandType getType()
  {
   return this.type;
  }

  public List<CommandKey> Values()
  {
   List<CommandKey> l = new List<CommandKey>()
   {
    KEY_A,
    KEY_D,
    KEY_K,
    KEY_LEFT,
    KEY_RIGHT,
    KEY_SPACE_BAR,
    KEY_W_PRESSED,
    KEY_UP_PRESSED,
    KEY_W_RELEASED,
    KEY_UP_RELEASED
   };
   return l;
  }
 }
}