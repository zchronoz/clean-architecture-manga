// <copyright file="IOutputPort.cs" company="Ivan Paulovich">
// Copyright © Ivan Paulovich. All rights reserved.
// </copyright>

namespace Application.Boundaries.Register
{
    /// <summary>
    ///     Output Port.
    /// </summary>
    public interface IOutputPort
        : IOutputPortStandard<RegisterOutput>, IOutputPortError
    {
        /// <summary>
        ///     Informs the user is already registered.
        /// </summary>
        /// <param name="message">Custom message.</param>
        void CustomerAlreadyRegistered(string message);
    }
}
