﻿namespace Computers.UI
{
    using System.Collections.Generic;

    public class PersonalComputer : Computer
    {
        internal PersonalComputer(
            Cpu cpu,
            Rammstein ram,
            IEnumerable<HardDriver> hardDrives,
            HardDriver videoCard)
            : base(cpu, ram, hardDrives, videoCard)
        {
        }

        public void Play(int guessNumber)
        {
            Cpu.rand(1, 10);
            var number = this.Ram.LoadValue();
            if (number + 1 != guessNumber + 1)
            {
                this.VideoCard.Draw(string.Format("You didn't guess the number {0}.", number));
            }
            else
            {
                this.VideoCard.Draw("You win!");
            }
        }
    }
}