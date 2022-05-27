<<<<<<< HEAD
namespace UnityEditor.TestTools
{
    /// <summary>
    /// An interface for a callback modifying the <see cref="BuildPlayerOptions"/> when building a player for running tests in the runtime.
    /// </summary>
    public interface ITestPlayerBuildModifier
    {
        /// <summary>
        /// A callback to modify the <see cref="BuildPlayerOptions"/> when building a player for test run. Return the modified version of the provided build options.
        /// </summary>
        /// <param name="playerOptions">The unmodified BuildPlayerOptions.</param>
        /// <returns>The modified BuildPlayerOptions.</returns>
        BuildPlayerOptions ModifyOptions(BuildPlayerOptions playerOptions);
    }
=======
namespace UnityEditor.TestTools
{
    /// <summary>
    /// An interface for a callback modifying the <see cref="BuildPlayerOptions"/> when building a player for running tests in the runtime.
    /// </summary>
    public interface ITestPlayerBuildModifier
    {
        /// <summary>
        /// A callback to modify the <see cref="BuildPlayerOptions"/> when building a player for test run. Return the modified version of the provided build options.
        /// </summary>
        /// <param name="playerOptions">The unmodified BuildPlayerOptions.</param>
        /// <returns>The modified BuildPlayerOptions.</returns>
        BuildPlayerOptions ModifyOptions(BuildPlayerOptions playerOptions);
    }
>>>>>>> d177c67f8fc2d304d2e7e6810126b61eeb7bdb3d
}