namespace DieRoller
{   
    /// <summary>
    /// Represents a single six sided die (1-6)
    /// </summary>
    public class Die // internal is defalt 이라 public 으로 바꿔줌
    {
        /// <summary>
        /// Creates the die and rolls it to start with
        /// a ramdom number
        /// </summary>
        // object을 생성할때, constructor가 호출되기 때문에 constructor 를 이렇게 만들어 줌
        public Die()
        {
            Roll();        
        }
        /// <summary>
        /// The current face up value of the die
        /// </summary>
        // Only 6 sided 니까 byte 이면 충분
        public byte FaceValue { get; private set; }
        // public 으로 두면 user 가 주사위 숫자를 조작할수있으니 set 만 private 로 설정한다

        /// <summary>
        /// True if the die is currently held
        /// </summary>
        // 주사위를 계속 던질지 말지 묻는거 인듯
        // IsHeld는 객체의 상태(주사위가 "보관"되었는지 여부)를 나타내므로, 
        // 값을 읽고 쓰기 위해 get과 set이 사용됩니다
        public bool IsHeld { get; set; }

        /// <summary>
        /// Set a new random <see cref="FaceValue"/>
        /// to the new number if the die is not currently held.
        /// Returns the <see cref="FaceValue"/>
        /// </summary>
        /// <returns>the new random number</returns>
        // Roll은 값을 얻거나(파라미터없음) 설정하는게 아니라 기능을 수행하는,
        // 행동을 정의하는 메서드이므로 get, set 이 필요없다.
        public byte Roll()
        {
            if (!IsHeld)
            {
                // Generate random number
                Random random = new();
                byte newValue = (byte)random.Next(1, 7);

                // Set to face value
                FaceValue = newValue;
            }

            // Return new number
            return FaceValue;


            /*throw new NotImplementedException();
            return value를 hardcode 하지 않고
            placeholder 개념도 되는 에러 방지 코드*/
        }
         
    }
}
