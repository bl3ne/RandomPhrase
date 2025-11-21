namespace RandomPhrase
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        int Clicked;
        int numero;
        Random RandomFrase = new Random();

        private void RandomButton_Clicked(object sender, EventArgs e)
        {
            // the variable 'numero' will contain a random number between 1 and 200
            numero = RandomFrase.Next(0, 201); //200 is not included 

            Clicked = Clicked + 1;



            if (numero == 1)
            {
                TxtFrase.Text = "Believe in yourself, even when no one else does.";
            }
            else if (numero == 2)
            {
                TxtFrase.Text = "Every small step forward is still progress.";
            }
            else if (numero == 3)
            {
                TxtFrase.Text = "You are capable of more than you think.";
            }
            else if (numero == 4)
            {
                TxtFrase.Text = "Difficult roads often lead to beautiful destinations.";
            }
            else if (numero == 5)
            {
                TxtFrase.Text = "Failure is just a lesson, not a life sentence.";
            }
            else if (numero == 6)
            {
                TxtFrase.Text = "Your future is created by what you do today, not tomorrow.";
            }
            else if (numero == 7)
            {
                TxtFrase.Text = "Dream big, start small, act now.";
            }
            else if (numero == 8)
            {
                TxtFrase.Text = "Progress, not perfection, is what truly matters.";
            }
            else if (numero == 9)
            {
                TxtFrase.Text = "You don’t have to be great to start, but you have to start to be great.";
            }
            else if (numero == 10)
            {
                TxtFrase.Text = "Your only limit is your mind.";
            }
            else if (numero == 11)
            {
                TxtFrase.Text = "Small daily improvements lead to stunning results.";
            }
            else if (numero == 12)
            {
                TxtFrase.Text = "The best time to start was yesterday. The next best time is now.";
            }
            else if (numero == 13)
            {
                TxtFrase.Text = "Success is the sum of small efforts repeated day in and day out.";
            }
            else if (numero == 14)
            {
                TxtFrase.Text = "You are stronger than your excuses.";
            }
            else if (numero == 15)
            {
                TxtFrase.Text = "Don’t watch the clock; do what it does. Keep going.";
            }
            else if (numero == 16)
            {
                TxtFrase.Text = "One day or day one. You decide.";
            }
            else if (numero == 17)
            {
                TxtFrase.Text = "If you can imagine it, you can create it.";
            }
            else if (numero == 18)
            {
                TxtFrase.Text = "You are not behind; you are just on your own path.";
            }
            else if (numero == 19)
            {
                TxtFrase.Text = "Start where you are, use what you have, do what you can.";
            }
            else if (numero == 20)
            {
                TxtFrase.Text = "Don’t be afraid to fail; be afraid not to try.";
            }
            else if (numero == 21)
            {
                TxtFrase.Text = "Great things never come from comfort zones.";
            }
            else if (numero == 22)
            {
                TxtFrase.Text = "You grow through what you go through.";
            }
            else if (numero == 23)
            {
                TxtFrase.Text = "Your potential is endless.";
            }
            else if (numero == 24)
            {
                TxtFrase.Text = "Your mindset is your superpower.";
            }
            else if (numero == 25)
            {
                TxtFrase.Text = "Discipline will take you where motivation cannot.";
            }
            else if (numero == 26)
            {
                TxtFrase.Text = "Success is built on consistency, not bursts of effort.";
            }
            else if (numero == 27)
            {
                TxtFrase.Text = "The only person you should try to be better than is the person you were yesterday.";
            }
            else if (numero == 28)
            {
                TxtFrase.Text = "Courage is taking the first step without seeing the whole staircase.";
            }
            else if (numero == 29)
            {
                TxtFrase.Text = "You don’t need to be perfect; you need to be persistent.";
            }
            else if (numero == 30)
            {
                TxtFrase.Text = "Challenges are what make you stronger.";
            }
            else if (numero == 31)
            {
                TxtFrase.Text = "The more you practice, the better you get.";
            }
            else if (numero == 32)
            {
                TxtFrase.Text = "Turn your doubts into determination.";
            }
            else if (numero == 33)
            {
                TxtFrase.Text = "Work in silence, let your results make the noise.";
            }
            else if (numero == 34)
            {
                TxtFrase.Text = "You are allowed to be a work in progress.";
            }
            else if (numero == 35)
            {
                TxtFrase.Text = "Your dreams are worth the effort.";
            }
            else if (numero == 36)
            {
                TxtFrase.Text = "Trust the process, even when it’s slow.";
            }
            else if (numero == 37)
            {
                TxtFrase.Text = "Success is a series of tiny wins.";
            }
            else if (numero == 38)
            {
                TxtFrase.Text = "Every expert was once a beginner.";
            }
            else if (numero == 39)
            {
                TxtFrase.Text = "You have survived 100% of your worst days.";
            }
            else if (numero == 40)
            {
                TxtFrase.Text = "The harder you work, the luckier you get.";
            }
            else if (numero == 41)
            {
                TxtFrase.Text = "Doubt kills more dreams than failure ever will.";
            }
            else if (numero == 42)
            {
                TxtFrase.Text = "Act as if it were impossible to fail.";
            }
            else if (numero == 43)
            {
                TxtFrase.Text = "Your habits today shape your tomorrow.";
            }
            else if (numero == 44)
            {
                TxtFrase.Text = "You are closer than you think.";
            }
            else if (numero == 45)
            {
                TxtFrase.Text = "Small steps every day lead to big changes.";
            }
            else if (numero == 46)
            {
                TxtFrase.Text = "You don’t have to feel ready to begin.";
            }
            else if (numero == 47)
            {
                TxtFrase.Text = "Your goals don’t care about your excuses.";
            }
            else if (numero == 48)
            {
                TxtFrase.Text = "Consistency beats intensity over time.";
            }
            else if (numero == 49)
            {
                TxtFrase.Text = "You are writing your own story right now.";
            }
            else if (numero == 50)
            {
                TxtFrase.Text = "The best project to work on is yourself.";
            }
            else if (numero == 51)
            {
                TxtFrase.Text = "Fear is temporary, regret is forever.";
            }
            else if (numero == 52)
            {
                TxtFrase.Text = "Success starts with a single decision.";
            }
            else if (numero == 53)
            {
                TxtFrase.Text = "You deserve the life you are working for.";
            }
            else if (numero == 54)
            {
                TxtFrase.Text = "When you feel like quitting, remember why you started.";
            }
            else if (numero == 55)
            {
                TxtFrase.Text = "Your future self is watching. Don’t disappoint them.";
            }
            else if (numero == 56)
            {
                TxtFrase.Text = "Be the energy you want to attract.";
            }
            else if (numero == 57)
            {
                TxtFrase.Text = "When nothing goes right, try a different way and keep going.";
            }
            else if (numero == 58)
            {
                TxtFrase.Text = "Don’t compare your chapter 1 to someone else’s chapter 20.";
            }
            else if (numero == 59)
            {
                TxtFrase.Text = "You’re capable of amazing things when you focus.";
            }
            else if (numero == 60)
            {
                TxtFrase.Text = "Use your struggles as fuel, not chains.";
            }
            else if (numero == 61)
            {
                TxtFrase.Text = "Impossible is just an opinion, not a fact.";
            }
            else if (numero == 62)
            {
                TxtFrase.Text = "One small positive thought can change your whole day.";
            }
            else if (numero == 63)
            {
                TxtFrase.Text = "Your journey is more important than your speed.";
            }
            else if (numero == 64)
            {
                TxtFrase.Text = "Every day is a new chance to change your life.";
            }
            else if (numero == 65)
            {
                TxtFrase.Text = "The secret of getting ahead is getting started.";
            }
            else if (numero == 66)
            {
                TxtFrase.Text = "Don’t limit your challenges; challenge your limits.";
            }
            else if (numero == 67)
            {
                TxtFrase.Text = "You are one decision away from a different life.";
            }
            else if (numero == 68)
            {
                TxtFrase.Text = "Action is the antidote to fear.";
            }
            else if (numero == 69)
            {
                TxtFrase.Text = "Make yourself proud, not others.";
            }
            else if (numero == 70)
            {
                TxtFrase.Text = "No one is you, and that is your power.";
            }
            else if (numero == 71)
            {
                TxtFrase.Text = "The pain of discipline is less than the pain of regret.";
            }
            else if (numero == 72)
            {
                TxtFrase.Text = "Consistency turns dreams into reality.";
            }
            else if (numero == 73)
            {
                TxtFrase.Text = "You don’t have to see the whole path, just take the next step.";
            }
            else if (numero == 74)
            {
                TxtFrase.Text = "You didn’t come this far to only come this far.";
            }
            else if (numero == 75)
            {
                TxtFrase.Text = "Your dreams need your hustle, not your doubts.";
            }
            else if (numero == 76)
            {
                TxtFrase.Text = "Success is earned, not given.";
            }
            else if (numero == 77)
            {
                TxtFrase.Text = "Progress feels slow until suddenly it’s obvious.";
            }
            else if (numero == 78)
            {
                TxtFrase.Text = "You can restart your day at any moment.";
            }
            else if (numero == 79)
            {
                TxtFrase.Text = "Turn “I can’t” into “How can I?”.";
            }
            else if (numero == 80)
            {
                TxtFrase.Text = "Hard work beats talent when talent doesn’t work hard.";
            }
            else if (numero == 81)
            {
                TxtFrase.Text = "Your comfort zone will kill your dreams.";
            }
            else if (numero == 82)
            {
                TxtFrase.Text = "Big results require small, smart decisions every day.";
            }
            else if (numero == 83)
            {
                TxtFrase.Text = "Don’t wait for motivation; create it through action.";
            }
            else if (numero == 84)
            {
                TxtFrase.Text = "You owe it to yourself to try.";
            }
            else if (numero == 85)
            {
                TxtFrase.Text = "Mistakes are proof that you are trying.";
            }
            else if (numero == 86)
            {
                TxtFrase.Text = "You are not your mistakes; you are your lessons.";
            }
            else if (numero == 87)
            {
                TxtFrase.Text = "Energy flows where attention goes.";
            }
            else if (numero == 88)
            {
                TxtFrase.Text = "You get what you focus on, so focus on what you want.";
            }
            else if (numero == 89)
            {
                TxtFrase.Text = "Be stubborn about your goals and flexible about your methods.";
            }
            else if (numero == 90)
            {
                TxtFrase.Text = "Every day you delay, someone else is getting ahead.";
            }
            else if (numero == 91)
            {
                TxtFrase.Text = "You can do hard things.";
            }
            else if (numero == 92)
            {
                TxtFrase.Text = "Your time is now, not later.";
            }
            else if (numero == 93)
            {
                TxtFrase.Text = "The person you want to be is built by what you do today.";
            }
            else if (numero == 94)
            {
                TxtFrase.Text = "Success is a choice you make repeatedly.";
            }
            else if (numero == 95)
            {
                TxtFrase.Text = "You didn’t fail; you learned how not to do it.";
            }
            else if (numero == 96)
            {
                TxtFrase.Text = "Don’t downgrade your dream to match your reality.";
            }
            else if (numero == 97)
            {
                TxtFrase.Text = "Your effort today will become your power tomorrow.";
            }
            else if (numero == 98)
            {
                TxtFrase.Text = "Stay focused; your breakthrough is coming.";
            }
            else if (numero == 99)
            {
                TxtFrase.Text = "You are allowed to start over as many times as needed.";
            }
            else if (numero == 100)
            {
                TxtFrase.Text = "Your fears are liars; your actions tell the truth.";
            }
            else if (numero == 101)
            {
                TxtFrase.Text = "Every minute spent doubting is a minute not improving.";
            }
            else if (numero == 102)
            {
                TxtFrase.Text = "Turn procrastination into preparation.";
            }
            else if (numero == 103)
            {
                TxtFrase.Text = "You are more resilient than you realize.";
            }
            else if (numero == 104)
            {
                TxtFrase.Text = "Do something today that your future self will thank you for.";
            }
            else if (numero == 105)
            {
                TxtFrase.Text = "Ambition is the first step; action is the second.";
            }
            else if (numero == 106)
            {
                TxtFrase.Text = "Your goals don’t work unless you do.";
            }
            else if (numero == 107)
            {
                TxtFrase.Text = "You are in control of your attitude, not your circumstances.";
            }
            else if (numero == 108)
            {
                TxtFrase.Text = "Success begins in your thoughts and grows in your actions.";
            }
            else if (numero == 109)
            {
                TxtFrase.Text = "Even slow progress is better than no progress.";
            }
            else if (numero == 110)
            {
                TxtFrase.Text = "You are capable of rewriting your story.";
            }
            else if (numero == 111)
            {
                TxtFrase.Text = "Discomfort is a sign of growth.";
            }
            else if (numero == 112)
            {
                TxtFrase.Text = "Never underestimate the power of starting small.";
            }
            else if (numero == 113)
            {
                TxtFrase.Text = "You don’t have to win today; you just have to not quit.";
            }
            else if (numero == 114)
            {
                TxtFrase.Text = "One focused hour can change your whole week.";
            }
            else if (numero == 115)
            {
                TxtFrase.Text = "Success is doing what others are not willing to do.";
            }
            else if (numero == 116)
            {
                TxtFrase.Text = "Don’t fear moving slowly; fear standing still.";
            }
            else if (numero == 117)
            {
                TxtFrase.Text = "The only way to fail is to stop trying.";
            }
            else if (numero == 118)
            {
                TxtFrase.Text = "Your vision will become clear when you start moving.";
            }
            else if (numero == 119)
            {
                TxtFrase.Text = "Results happen over time, not overnight.";
            }
            else if (numero == 120)
            {
                TxtFrase.Text = "Every day is a new opportunity to level up.";
            }
            else if (numero == 121)
            {
                TxtFrase.Text = "Your actions reveal your priorities more than your words.";
            }
            else if (numero == 122)
            {
                TxtFrase.Text = "You won’t always be motivated, so learn to be disciplined.";
            }
            else if (numero == 123)
            {
                TxtFrase.Text = "What you do today can improve all your tomorrows.";
            }
            else if (numero == 124)
            {
                TxtFrase.Text = "You are not stuck; you are just paused.";
            }
            else if (numero == 125)
            {
                TxtFrase.Text = "The gap between dreams and reality is called action.";
            }
            else if (numero == 126)
            {
                TxtFrase.Text = "Your excuses are stealing your potential.";
            }
            else if (numero == 127)
            {
                TxtFrase.Text = "Be patient with yourself; greatness takes time.";
            }
            else if (numero == 128)
            {
                TxtFrase.Text = "If it scares you, it’s probably worth doing.";
            }
            else if (numero == 129)
            {
                TxtFrase.Text = "Don’t wait for the right moment; create it.";
            }
            else if (numero == 130)
            {
                TxtFrase.Text = "Keep going; the best is yet to come.";
            }
            else if (numero == 131)
            {
                TxtFrase.Text = "Success is often just one more attempt away.";
            }
            else if (numero == 132)
            {
                TxtFrase.Text = "You are allowed to outgrow your old life.";
            }
            else if (numero == 133)
            {
                TxtFrase.Text = "Motivation gets you started; habits keep you going.";
            }
            else if (numero == 134)
            {
                TxtFrase.Text = "You are building something important, even if you can’t see it yet.";
            }
            else if (numero == 135)
            {
                TxtFrase.Text = "Dreams only work if you do.";
            }
            else if (numero == 136)
            {
                TxtFrase.Text = "Commit now; figure it out on the way.";
            }
            else if (numero == 137)
            {
                TxtFrase.Text = "Your consistency is more important than your intensity.";
            }
            else if (numero == 138)
            {
                TxtFrase.Text = "Small wins every day beat rare big wins.";
            }
            else if (numero == 139)
            {
                TxtFrase.Text = "Stop doubting yourself and start doing.";
            }
            else if (numero == 140)
            {
                TxtFrase.Text = "Discipline is choosing what you want most over what you want now.";
            }
            else if (numero == 141)
            {
                TxtFrase.Text = "You can be both a masterpiece and a work in progress.";
            }
            else if (numero == 142)
            {
                TxtFrase.Text = "If you keep going, you cannot lose.";
            }
            else if (numero == 143)
            {
                TxtFrase.Text = "Turn your “what if” into “I did”.";
            }
            else if (numero == 144)
            {
                TxtFrase.Text = "Strength grows in the moments you think you can’t go on but you keep going anyway.";
            }
            else if (numero == 145)
            {
                TxtFrase.Text = "You’re not late; you’re right on time for your own path.";
            }
            else if (numero == 146)
            {
                TxtFrase.Text = "The more you learn, the more you earn in life.";
            }
            else if (numero == 147)
            {
                TxtFrase.Text = "You owe it to your potential to try your best.";
            }
            else if (numero == 148)
            {
                TxtFrase.Text = "Don’t fear failure; fear being in the same place next year.";
            }
            else if (numero == 149)
            {
                TxtFrase.Text = "Your progress might be invisible now, but it’s happening.";
            }
            else if (numero == 150)
            {
                TxtFrase.Text = "Every day is a chance to rewrite your habits.";
            }
            else if (numero == 151)
            {
                TxtFrase.Text = "Stop waiting for permission to chase your dreams.";
            }
            else if (numero == 152)
            {
                TxtFrase.Text = "You didn’t come this far just to be average.";
            }
            else if (numero == 153)
            {
                TxtFrase.Text = "Greatness starts with showing up.";
            }
            else if (numero == 154)
            {
                TxtFrase.Text = "You are capable of surprising yourself.";
            }
            else if (numero == 155)
            {
                TxtFrase.Text = "You are not your past; you are your choices now.";
            }
            else if (numero == 156)
            {
                TxtFrase.Text = "Let your actions reflect your ambitions.";
            }
            else if (numero == 157)
            {
                TxtFrase.Text = "Motivation fades, but purpose stays.";
            }
            else if (numero == 158)
            {
                TxtFrase.Text = "You can reset your life with one brave decision.";
            }
            else if (numero == 159)
            {
                TxtFrase.Text = "Be consistent with your effort, not your excuses.";
            }
            else if (numero == 160)
            {
                TxtFrase.Text = "Don’t let your mood decide your future.";
            }
            else if (numero == 161)
            {
                TxtFrase.Text = "The best way to predict your future is to create it.";
            }
            else if (numero == 162)
            {
                TxtFrase.Text = "If you keep showing up, success becomes inevitable.";
            }
            else if (numero == 163)
            {
                TxtFrase.Text = "Your dream life requires a new version of you.";
            }
            else if (numero == 164)
            {
                TxtFrase.Text = "The more you focus, the faster you grow.";
            }
            else if (numero == 165)
            {
                TxtFrase.Text = "You’re allowed to take breaks, but never to give up.";
            }
            else if (numero == 166)
            {
                TxtFrase.Text = "Big change starts with small courage.";
            }
            else if (numero == 167)
            {
                TxtFrase.Text = "Your work today is an investment, not a waste.";
            }
            else if (numero == 168)
            {
                TxtFrase.Text = "Excuses will always be there; opportunities won’t.";
            }
            else if (numero == 169)
            {
                TxtFrase.Text = "You’re closer than you were yesterday; that’s what counts.";
            }
            else if (numero == 170)
            {
                TxtFrase.Text = "Hustle in private, shine in public.";
            }
            else if (numero == 171)
            {
                TxtFrase.Text = "Don’t let temporary feelings change long-term goals.";
            }
            else if (numero == 172)
            {
                TxtFrase.Text = "You have everything you need to start.";
            }
            else if (numero == 173)
            {
                TxtFrase.Text = "You can’t lose if you learn from every outcome.";
            }
            else if (numero == 174)
            {
                TxtFrase.Text = "Trust your grind; it’s leading somewhere.";
            }
            else if (numero == 175)
            {
                TxtFrase.Text = "Comfort is the enemy of progress.";
            }
            else if (numero == 176)
            {
                TxtFrase.Text = "Your efforts are planting seeds you can’t see yet.";
            }
            else if (numero == 177)
            {
                TxtFrase.Text = "Ambition means doing more than what’s convenient.";
            }
            else if (numero == 178)
            {
                TxtFrase.Text = "You are building momentum with every action.";
            }
            else if (numero == 179)
            {
                TxtFrase.Text = "Your dream is worth the sacrifice.";
            }
            else if (numero == 180)
            {
                TxtFrase.Text = "Keep moving; the hardest part is over once you start.";
            }
            else if (numero == 181)
            {
                TxtFrase.Text = "Believe in the process more than in your doubts.";
            }
            else if (numero == 182)
            {
                TxtFrase.Text = "Success is a habit, not an event.";
            }
            else if (numero == 183)
            {
                TxtFrase.Text = "You are not chasing perfection; you are chasing progress.";
            }
            else if (numero == 184)
            {
                TxtFrase.Text = "Every setback prepares you for a comeback.";
            }
            else if (numero == 185)
            {
                TxtFrase.Text = "You have what it takes to figure it out.";
            }
            else if (numero == 186)
            {
                TxtFrase.Text = "Stop waiting to feel ready; start and grow on the way.";
            }
            else if (numero == 187)
            {
                TxtFrase.Text = "The work you avoid is the growth you delay.";
            }
            else if (numero == 188)
            {
                TxtFrase.Text = "Your time, energy, and focus are your greatest assets.";
            }
            else if (numero == 189)
            {
                TxtFrase.Text = "Success starts in your mind before it shows in your life.";
            }
            else if (numero == 190)
            {
                TxtFrase.Text = "You don’t have to rush; you just have to move.";
            }
            else if (numero == 191)
            {
                TxtFrase.Text = "You are designed to grow, not to stay the same.";
            }
            else if (numero == 192)
            {
                TxtFrase.Text = "Be proud of how far you’ve already come.";
            }
            else if (numero == 193)
            {
                TxtFrase.Text = "Discipline turns dreams into plans and plans into reality.";
            }
            else if (numero == 194)
            {
                TxtFrase.Text = "You are one habit away from a different life.";
            }
            else if (numero == 195)
            {
                TxtFrase.Text = "The only way to know your limits is to test them.";
            }
            else if (numero == 196)
            {
                TxtFrase.Text = "Choose progress over comfort today.";
            }
            else if (numero == 197)
            {
                TxtFrase.Text = "Your dream doesn’t work if you don’t.";
            }
            else if (numero == 198)
            {
                TxtFrase.Text = "The struggle you feel now is the strength you’ll feel later.";
            }
            else if (numero == 199)
            {
                TxtFrase.Text = "Do it for the person you promised yourself you’d become.";
            }
            else if (numero == 200)
            {
                TxtFrase.Text = "You deserve to see what happens if you don’t give up.";
            }

            //it adds the number of times the button has been clicked
            TxtClickedTimes.Text = "You have clicked the button " + Clicked + " times";

        }
    }
}

