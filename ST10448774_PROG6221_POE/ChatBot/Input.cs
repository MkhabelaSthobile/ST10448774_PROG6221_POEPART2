using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot
{
    public class Input
    {
        private string input;
        private Dictionary<string, string> memory = new Dictionary<string, string>();

        public Input() 
        { 
            input = null;
        }

        public Input(string input)
        {
            this.input = input;
        }

        public string RespondToInput(string input, string userName)
        {

            string[] phishingTips = { "Be cautious of emails asking for personal information.",
                                      "Avoid clicking on suspicious links or attachments.",
                                      "Always verify the sender's email address.",
                                      "Use multi-factor authentication when available.",
                                      "Look for grammar and spelling errors in emails."};

            string[,] cyberAttacks = { {"Malware", "Any software designed to harm or disrupt computer systems, including viruses, ransomware, and trojans."},
                                       {"Ransomware", "A type of malware that encrypts files or computer systems and demands a ransom for their decryption. "},
                                       {"DDoS (Distributed Denial of Service) attack", "An attack that floods a target system with traffic, making it unavailable to legitimate users."},
                                       {"SQL Injection", "This is a web security vulnerability that allows an attacker to manipulate database queries."},
                                       {"Cross-Site Scripting", "XSS is a web security vulnerability where attackers inject malicious code into websites."},
                                       {"Man-in-the-Middle (MITM) attack", "This attack occurs when an attacker intercepts communication between two parties, potentially stealing data or injecting malicious code."} };

            string[,] securityMeasures = { {"Encription", "The process of converting data into a secure format that can only be decrypted by authorized individuals."},
                                           {"Two-factor authentication (2FA)", "2FA adds an extra layer of security by requiring a second form of verification, such as a code sent to a mobile phone, in addition to a password."},
                                           {"Firewall", "This is a network security device that monitors and controls network traffic based on defined security rules."},
                                           {"Passkeys", "These are digital credentials that use biometric authentication or a PIN instead of passwords, offering increased security and convenience."},
                                           {"Patch Management", "Involves regularly updating software to address vulnerabilities and security flaws."} };

            
            Console.ForegroundColor = ConsoleColor.Blue;

            if (input.Contains("hey") || input.Contains("hello"))
            {
                if (input.Contains("how are you"))
                {
                    Console.WriteLine("Hey there! I'm as good as a chatbot can be. How are you?\n");

                }
                else
                {
                    Console.WriteLine("Hey there!\n");
                }

            }
            else if (input.Contains("how are you"))
            {
                Console.WriteLine("I'm as good as a chatbot can be. How are you?\n");

            }
            else if (input.Contains("good") || input.Contains("great") || input.Contains("amazing") || input.Contains("fine"))
            {
                Console.WriteLine("That's good to know. How can I make your day better?\n");

            }
            else if (input.Contains("not good") || input.Contains("bad") || input.Contains("sad") || input.Contains("angry"))
            {
                Console.WriteLine("I'm sorry to hear that. How can I make your day better?\n");

            }
            else if (input.Contains("purpose") || input.Contains("your purpose") || input.Contains("what do you do") || input.Contains("help"))
            {
                Console.WriteLine("I'm here to help you stay safe online. You can ask me about cybersecurity.\n");

            }
            else if (input.Contains("worried") || input.Contains("scared") || input.Contains("anxious"))
            {
                Console.WriteLine("It’s okay to feel that way. Cybersecurity can be confusing, but I’ll help you understand it.\n");
                Console.ResetColor();
            }
            else if (input.Contains("curious"))
            {
                Console.WriteLine("Curiosity is great! Let’s explore cybersecurity together.\n");
                Console.ResetColor();
            }
            else if (input.Contains("frustrated") || input.Contains("confused"))
            {
                Console.WriteLine("No worries. Just ask your question in a different way, and I’ll do my best to help.\n");
                Console.ResetColor();
            }
            else if ((input.Contains("what can I ask you") || input.Contains("can I ask you") || input.Contains("ask")) || input.Contains("topics") || input.Contains("topic"))
            {
                Console.WriteLine("You can ask me about the topics mentioned above.\n");
                AskUserPreferences();

            }
            else if (input.Contains("define") && input.Contains("cybersecurity") || input.Contains("what is cybersecurity"))
            {
                Console.WriteLine("Cybersecurity is the practice of protecting systems, networks, and data from digital attacks.\n");
                
            }
            else if (input.Contains("define") && input.Contains("phishing") || input.Contains("what is phishing"))
            {
                Console.WriteLine("Phishing is a cyberattack where attackers impersonate trusted entities to trick people into revealing sensitive information.\n");
                
            }
            else if ((input.Contains("how") && input.Contains("safe") || input.Contains("precautions")) && input.Contains("phishing"))
            {
                Console.WriteLine("Safety precautions against phishing include:");
                Console.WriteLine("- Don't share personal info with unknown sources");
                Console.WriteLine("- Use strong, unique passwords");
                Console.WriteLine("- Enable multi-factor authentication");
                Console.WriteLine("- Avoid clicking on suspicious links or email attachments\n");
                
            }
            else if (input.Contains("tell me more") && input.Contains("phishing safety precautions") || input.Contains("phishing safety precautions"))
            {
                Console.WriteLine("Safety precautions against phishing include:");
                Console.WriteLine("- Don't share personal info with unknown sources" + "\nAs long as you don't know the person online, do not give them any personal information.\n");
                Console.WriteLine("- Use strong, unique passwords" + "\nAvoid using the same password across multiple accounts, and consider using a password manager to generate and store strong, unique passwords.\n");
                Console.WriteLine("- Enable multi-factor authentication" + "\n(MFA) means requiring users to provide two or more verification factors, such as a password and a code sent to their phone, before they can access an account or system.\n");
                Console.WriteLine("- Avoid clicking on suspicious links or email attachments" + "\nHover over links to see where they actually lead before clicking, and be cautious about opening attachments from unknown senders.\n");

            }
            else if (input.Contains("types") && input.Contains("phishing"))
            {
                Console.WriteLine("Types of phishing include:");
                Console.WriteLine("- Email phishing");
                Console.WriteLine("- Spear phishing");
                Console.WriteLine("- Smishing (SMS phishing)");
                Console.WriteLine("- Vishing (voice phishing)");
                Console.WriteLine("- Clone phishing\n");

            }
            else if (input.Contains("elaborate") && input.Contains("types of phishing") || input.Contains("tell me more") && input.Contains("types of phishing"))
            {
                Console.WriteLine("- Email phishing\n" + "The most prevalent type, using emails that appear legitimate to trick recipients into revealing sensitive information or clicking malicious links.\n");
                Console.WriteLine("- Spear phishing\n" + "Targets a specific individual or group within an organization, often with personalized messages, to exploit their trust and gather more specific information.\n");
                Console.WriteLine("- Smishing (SMS phishing)\n" + "Utilizes SMS messages to deceive victims into revealing information or clicking malicious links.\n");
                Console.WriteLine("- Vishing (voice phishing)\n" + "Involves phone calls designed to trick individuals into revealing personal information.\n");
                Console.WriteLine("- Clone phishing\n" + "Creates exact replicas of legitimate emails or websites to trick victims into providing sensitive information.\n");
            }
            else if ((input.Contains("define") || input.Contains("what is")) && input.Contains("password safety"))
            {
                Console.WriteLine("Password safety means using good habits to protect your accounts and sensitive information.\n");

            }
            else if (input.Contains("practice") || (input.Contains("practices") || input.Contains("how") || input.Contains("precautions")) && input.Contains("password"))
            {
                Console.WriteLine("Password safety practices include:");
                Console.WriteLine("- Use strong, complex passwords");
                Console.WriteLine("- Avoid writing down or sharing passwords");
                Console.WriteLine("- Use a password manager\n");

            }
            else if ((input.Contains("what is") || input.Contains("safe browsing")) && input.Contains("safe"))
            {
                Console.WriteLine("Safe browsing is using tools and habits that protect you from online threats.\n");

            }
            else if (input.Contains("practice") || input.Contains("practices") && input.Contains("safe browsing"))
            {
                Console.WriteLine("Safe browsing practices include:");
                Console.WriteLine("- Keep antivirus software updated");
                Console.WriteLine("- Check that website URLs are correct");
                Console.WriteLine("- Use HTTPS-secured sites");
                Console.WriteLine("- Don't click suspicious links or ads\n");

            }
            else if (input.Contains("tools") && input.Contains("safe browsing"))
            {
                Console.WriteLine("Tools used for safe browsing include:");
                Console.WriteLine("- Google Safe Browsing (used by Chrome and Firefox)");
                Console.WriteLine("- Microsoft Defender SmartScreen (used by Edge)");
                Console.WriteLine("- Antivirus software with web protection features\n");

            }
            else if (input.Contains("What is password safety") || input.Contains("password safety"))
            {
                Console.WriteLine("Password safety is the practice of creating, managing, and protecting strong passwords to secure online accounts and prevent unauthorized access.\n");
            }
            else if (input.Contains("scam"))
            {
                Console.WriteLine("A scam is a deceptive scheme or illegal trick, often perpetrated online, with the goal of defrauding individuals or organizations.\n");
            }
            else if (input.Contains("types") && input.Contains("phishing"))
            {
                Console.WriteLine("Types of scams include:");
                Console.WriteLine("- Investment scams");
                Console.WriteLine("- Romance fraud");
                Console.WriteLine("- Job scams");
                Console.WriteLine("- Identity theft");
            }
            else if (input.Contains("elaborate") && input.Contains("scams") || input.Contains("tell me more") && input.Contains("scams"))
            {
                Console.WriteLine("- Investment scams\n" + "These scams involve fraudulent investment opportunities, often promising high returns with little risk.\n");
                Console.WriteLine("- Romance fraud\n" + "Scammers build relationships with victims online, then request money or personal information under false pretenses.\n");
                Console.WriteLine("- Job Scams\n" + "Scammers offer fake job opportunities, often requiring upfront fees or personal information.\n");
                Console.WriteLine("- Identity theft\n" + "Scammers steal personal information to open fraudulent accounts or commit other crimes.\n");

            }
            else if (input.Contains("privacy"))
            {
                Console.WriteLine("Data privacy, also called information privacy, is the principle that a person should have control over their personal data, including the ability to decide how organizations collect, store and use their data.\n");
            }
            else if (input.Contains("types") && input.Contains("privacy practices") || input.Contains("privacy practices"))
            {
                Console.WriteLine("Privacy practices include:");
                Console.WriteLine("- Make use of privacy policies");
                Console.WriteLine("- Restrict access to personal data to authorized personnel");
                Console.WriteLine("- Obtain explicit consent to make use of personal data");
                Console.WriteLine("- Implement procedures to ensure that data can be recovered in case of loss or damage.\n");
            }
            else if (input.Contains("phishing tip"))
            {
                Random rand = new Random();
                int index = rand.Next(phishingTips.Length);
                Console.WriteLine(phishingTips[index] + "\n");
            }
            else if (input.Contains("phishing tips"))
            {
                for (int i = 0; i < phishingTips.Length; ++i)
                {
                    Console.WriteLine("-" + phishingTips[i] + "\n");
                }

            }
            else if (input.Contains("common cyberattacks") || input.Contains("common cyber attacks") || input.Contains("a list of cyberattacks") || input.Contains("cyberattacks"))
            {
                for (int i = 0; i < cyberAttacks.Length; i++)
                {
                    Console.WriteLine("~ " + cyberAttacks[i, 0] + "\n");
                }

                Console.WriteLine("Would you like the definitions of these cyberattacks? Select a response:\n - 'No'\n - 'Yes'\n Or type the name of a cyberattack to learn more:");
                string answer = Console.ReadLine();

                switch (answer)
                {
                    case "No":
                        Console.WriteLine("Ok, no problem.\nFeel free to ask me anything else.");
                        break;

                    case "Yes":
                        for (int i = 0; i < cyberAttacks.GetLength(0); i++)
                        {
                            Console.WriteLine(cyberAttacks[i, 0] + "\n" + cyberAttacks[i, 1] + "\n");
                        }
                        break;

                    default:
                        bool found = false;
                        for (int i = 0; i < cyberAttacks.GetLength(0); i++)
                        {
                            if (cyberAttacks[i, 0].Equals(answer, StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine(cyberAttacks[i, 0] + "\n" + cyberAttacks[i, 1] + "\n");
                                found = true;
                                break;
                            }
                        }
                        if (!found)
                        {
                            Console.WriteLine("Your response was not recognized. Please try again.\n");
                        }
                        break;
                }

            }
            else if (input.Contains("security measures") || input.Contains("a list of security measures"))
            {
                for (int i = 0; i < securityMeasures.GetLength(0); i++)
                {
                    Console.WriteLine("~ " + securityMeasures[i, 0] + "\n");
                }

                Console.WriteLine("Would you like the definitions of these security measures? Select a response:\n - 'No'\n - 'Yes'\n Or type the name of a security measure to learn more:");
                string response = Console.ReadLine();

                switch (response)
                {
                    case "No":
                        Console.WriteLine("Ok, no problem.\nFeel free to ask me anything else.");
                        break;

                    case "Yes":
                        for (int i = 0; i < securityMeasures.GetLength(0); i++)
                        {
                            Console.WriteLine(securityMeasures[i, 0] + "\n" + securityMeasures[i, 1] + "\n");
                        }
                        break;

                    default:
                        bool found = false;
                        for (int i = 0; i < securityMeasures.GetLength(0); i++)
                        {
                            if (securityMeasures[i, 0].Equals(response, StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine(securityMeasures[i, 0] + "\n" + securityMeasures[i, 1] + "\n");
                                found = true;
                                break;
                            }
                        }
                        if (!found)
                        {
                            Console.WriteLine("Your response was not recognized. Please try again.\n");
                        }
                        break;
                }

            }
            else if (input.Contains("tell me more") || input.Contains("elaborate"))
            {
                Elaborate(input);
            }
            else if (input.Contains("remember what cybersecurity topic") || input.Contains("my cybersecurity interest"))
            {
                Console.WriteLine("You mentioned that you are interested in " + memory["interest"]); 
            }
            else if (input.Contains("what is") || input.Contains("level") || input.Contains("what is") && input.Contains("level of cybersecurity"))
            {
                Console.WriteLine("You mentioned that your level of cybersecurity knowledge is " + memory["knowledgeLevel"]);
            }
            else if (input.Contains("am I") && input.Contains("social media"))
            {
                if(memory["social media"].ToLower() == "yes")
                {
                    Console.WriteLine(memory["social media"] + ", you are.");
                }
                else
                {
                    Console.WriteLine(memory["social media"] + ", you are not.");
                }
            }
            else if (input.Contains("what do you remember about me"))
            {
                Console.WriteLine("Here's what I remember about you:");
                Console.WriteLine("• Your cybersecurity interest is: " + memory["interest"]);
                Console.WriteLine("• Your knowledge level is: " + memory["knowledgeLevel"]);
                Console.WriteLine("• Active on social media: " + memory["social media"]);
            }
            else if (input.Contains("what is my username") || input.Contains("what is my name"))
            {
                Console.WriteLine("Your username is " + userName);
            }
            else
            {
                Console.WriteLine("Hmm... I didn’t quite understand that. Can you rephrase?");

            }

            Console.ResetColor();

            return input;
        }

        public string Elaborate(string input)
        {
            var elaborations = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Cybersecurity", "Cybersecurity includes practices like using strong passwords, enabling firewalls, keeping software updated, and being cautious online."},
                { "Cyberattack", "Cyberattacks include malware, ransomware, phishing, and other tactics used to gain unauthorized access or cause damage."},
                { "Cyberattacks", "Cyberattacks include malware, ransomware, phishing, and other tactics used to gain unauthorized access or cause damage."},
                { "Phishing", "Phishing emails may look legitimate but often contain suspicious links, urgent messages, and ask for personal info."},
                { "Password safety", "Avoid using common passwords. Use a password manager and enable two-factor authentication where possible."},
                { "Safe browsing", "Avoid unknown sites, check for HTTPS, don’t download random files, and use browser security extensions."},
                { "Password safety", "Make sure to use strong, unique passwords for each account. Avoid using personal details in your passwords"},
                { "Scam", "Be cautious of offers that seem too good to be true, and never share personal or banking info with strangers."},
                { "Scams", "Be cautious of offers that seem too good to be true, and never share personal or banking info with strangers."},
                { "Privacy", "Protect your privacy by limiting what you share online, using encrypted messaging apps, and regularly checking app permissions."}
            };

            if (elaborations.ContainsKey(input))
                Console.WriteLine(elaborations[input] + "\n");
            else
                Console.WriteLine("Sorry, I can't elaborate further on that topic.\n");

            return input;
        }

        public void AskUserPreferences()
        {
            Console.WriteLine("Before we continue, I'd like to get to know your cybersecurity interests better. Please answer the following questions.\n");

            // 1. Interest
            Console.WriteLine("1. What cybersecurity topic are you most interested in? (e.g., phishing, privacy, password safety, cyberattacks)");
            string interest = Console.ReadLine().Trim().ToLower();
            if (string.IsNullOrEmpty(interest))
            {
                interest = "general cybersecurity";
            }
            memory["interest"] = interest;
            Console.WriteLine("Got it! I'll remember that you're interested in " + interest + ".\n");

            // 2. Knowledge level
            string level = "";
            while (true)
            {
                Console.WriteLine("2. What’s your level of cybersecurity knowledge? (beginner, intermediate, expert)");
                level = Console.ReadLine().Trim().ToLower();

                switch (level)
                {
                    case "beginner":
                    case "novice":
                        level = "beginner";
                        break;
                    case "intermediate":
                        break;
                    case "expert":
                    case "advanced":
                    case "pro":
                        level = "expert";
                        break;
                    default:
                        Console.WriteLine("Sorry, I didn't understand that. Please type: beginner, intermediate, or expert.");
                        continue;
                }
                break;
            }
            memory["knowledgeLevel"] = level;
            Console.WriteLine("Thanks! I'll remember you're a(n) " + level + " user.\n");

            // 3. Social media
            string active = "";
            while (true)
            {
                Console.WriteLine("3. Are you active on social media? (Yes/No)");
                active = Console.ReadLine().Trim().ToLower();

                if (active == "yes" || active == "y")
                {
                    active = "Yes";
                    break;
                }
                else if (active == "no" || active == "n")
                {
                    active = "No";
                    break;
                }
                else
                {
                    Console.WriteLine("Please answer 'Yes' or 'No'.");
                }
            }
            memory["social media"] = active;
            Console.WriteLine("Understood! I'll provide friendly explanations when possible.\n");
        }



    }
}
