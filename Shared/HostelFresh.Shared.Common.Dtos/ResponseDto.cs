namespace HostelFresh.Shared.Common.Dtos
{
    /// <summary>
    /// Базовый ответ сервера
    /// </summary>
    /// <typeparam name="T">Тип данных</typeparam>
    public record ResponseDto<T> where T : class
    {
        /// <summary>
        /// Статусный код ответа от сервера
        /// </summary>
        public int StatusCode { get; set; }

        /// <summary>
        /// Данные
        /// </summary>
        public T? Data { get; set; }

        /// <summary>
        /// Список ошибок
        /// </summary>
        public IReadOnlyCollection<string>? Errors { get; set; }
    }
}
