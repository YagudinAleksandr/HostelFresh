namespace HostelFresh.Application.Abstractions.Services
{
    /// <summary>
    /// Сервис логирования
    /// </summary>
    /// <typeparam name="T">Класс логирования</typeparam>
    public interface ILoggingService<T> where T : class
    {
        /// <summary>
        /// Логирование информации
        /// </summary>
        /// <param name="message">Сообщение лога</param>
        void LogInformation(string message);

        /// <summary>
        /// Логирование предупреждений
        /// </summary>
        /// <param name="message">Сообщение лога</param>
        void LogWarning(string message);

        /// <summary>
        /// Логирование исключений
        /// </summary>
        /// <param name="message">Сообщение исключения</param>
        /// <param name="exception">Исключение</param>
        void LogError(string message, Exception exception);
    }
}
