using System.ComponentModel.DataAnnotations;

namespace GAME_MAN.Models
{
    public class Score
    {
        [Key] // Атрибут указывает, что это первичный ключ
        public int ID_score { get; set; } // Первичный ключ

        public int Score_number { get; set; } // Поле для хранения счета
    }
}
