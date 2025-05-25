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
        public Input() 
        { 
            input = null;
        }

        public Input(string input)
        {
            this.input = input;
        }

        public string RespondToInput(string input)
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

            string lastTopic = "";

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
                Console.WriteLine("It’s okay to feel that way. Cybersecurity can be confusing, but I’ll help you understand it.");
                Console.ResetColor();
            }
            else if (input.Contains("curious") || input.Contains("interested"))
            {
                Console.WriteLine("Curiosity is great! Let’s explore cybersecurity together.");
                Console.ResetColor();
            }
            else if (input.Contains("frustrated") || input.Contains("confused"))
            {
                Console.WriteLine("No worries. Just ask your question in a different way, and I’ll do my best to help.");
                Console.ResetColor();
            }
            else if ((input.Contains("what can I ask you") || input.Contains("can I ask you") || input.Contains("ask")) || input.Contains("topics") || input.Contains("topic"))
            {
                Console.WriteLine("You can ask me about phishing, password safety, or safe browsing.\n");

            }


            else if ((input.Contains("define") || input.Contains("what is") || input.Contains("about")) && input.Contains("cybersecurity"))
            {
                Console.WriteLine("Cybersecurity is the practice of protecting systems, networks, and data from digital attacks.\n");
                lastTopic = "define cybersecurity";
            }
            else if (input.ToLower().Contains("tell me more") && lastTopic == "define cybersecurity")
            {
                
                    Console.WriteLine("Cybersecurity encompasses the practices, technologies, and processes used to protect computer systems, networks, and data from unauthorized access, use, disclosure, disruption, modification, or destruction.");
                
            }

            else if ((input.Contains("define") || input.Contains("what is") || input.Contains("about")) && input.Contains("phishing"))
            {
                Console.WriteLine("Phishing is a cyberattack where attackers impersonate trusted entities to trick people into revealing sensitive information.\n");
                lastTopic = "define phishing";
            }
            else if (input.ToLower().Contains("tell me more"))
            {
                if (lastTopic == "define phishing")
                    Console.WriteLine("Phishing emails often look like they come from trusted sources.");
                else
                    Console.WriteLine("Can you clarify what you want to know more about?");
            }

            //Check

            else if ((input.Contains("how") || input.Contains("safe") || input.Contains("precautions")) && input.Contains("phishing"))
            {
                Console.WriteLine("Safety precautions against phishing include:");
                Console.WriteLine("- Don't share personal info with unknown sources");
                Console.WriteLine("- Use strong, unique passwords");
                Console.WriteLine("- Enable multi-factor authentication");
                Console.WriteLine("- Avoid clicking on suspicious links or email attachments\n");
                lastTopic = "phishing safety precautions";

            }
            else if (input.ToLower().Contains("tell me more"))
            {
                if (lastTopic == "phishing safety precautions")
                {
                    Console.WriteLine("Safety precautions against phishing include:");
                    Console.WriteLine("- Don't share personal info with unknown sources" + "\nAs long as you don't know the person online, do not give them any personal information.\n");
                    Console.WriteLine("- Use strong, unique passwords" + "\nAvoid using the same password across multiple accounts, and consider using a password manager to generate and store strong, unique passwords.\n");
                    Console.WriteLine("- Enable multi-factor authentication" + "\n(MFA) means requiring users to provide two or more verification factors, such as a password and a code sent to their phone, before they can access an account or system.\n");
                    Console.WriteLine("- Avoid clicking on suspicious links or email attachments" + "\nHover over links to see where they actually lead before clicking, and be cautious about opening attachments from unknown senders.\n");

                }
                else
                {
                    Console.WriteLine("Can you clarify what you want to know more about?");
                }

            }

            else if (input.Contains("types") || input.Contains("examples") && input.Contains("phishing"))
            {
                Console.WriteLine("Examples of phishing include:");
                Console.WriteLine("- Email phishing");
                Console.WriteLine("- Spear phishing");
                Console.WriteLine("- Smishing (SMS phishing)");
                Console.WriteLine("- Vishing (voice phishing)");
                Console.WriteLine("- Clone phishing\n");

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
                Console.WriteLine("Make sure to use strong, unique passwords for each account. Avoid using personal details in your passwords.\n");
            }
            else if (input.Contains("scam"))
            {
                Console.WriteLine("Watch out for online scams. Be cautious of offers that seem too good to be true, and never share personal or banking info with strangers.\n");
            }
            else if (input.Contains("privacy"))
            {
                Console.WriteLine("Protect your privacy by limiting what you share online, using encrypted messaging apps, and regularly checking app permissions.\n");
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
            else if (input.Contains("common cyberattacks") || input.Contains("common cyber attacks"))
            {
                for (int i = 0; i < cyberAttacks.Length; i++)
                {
                    Console.WriteLine("~ " + cyberAttacks[i, 0] + "\n");
                }

                Console.WriteLine("Would you like the definitions of these cyberattacks? Select a response from the following options " + "\n -'No'\n -'Yes'\n You may choose one cyber attack to be defined\n");

                for (int i = 0; i < cyberAttacks.Length; i++)
                {
                    switch (input)
                    {
                        case "No":
                            Console.WriteLine("Ok no problem\n Feel free to ask me anything else.");
                            break;

                        case "Yes":
                            Console.WriteLine(cyberAttacks[i, 0] + "\n" + cyberAttacks[i, 1]);
                            break;

                        case "Malware":
                            Console.WriteLine(cyberAttacks[0, 0] + "\n" + cyberAttacks[0, 1]);
                            break;

                        case "Ransomware":
                            Console.WriteLine(cyberAttacks[1, 0] + "\n" + cyberAttacks[1, 1]);
                            break;

                        case "DDoS (Distributed Denial of Service) attack":
                            Console.WriteLine(cyberAttacks[2, 0] + "\n" + cyberAttacks[2, 1]);
                            break;

                        case "SQL Injection":
                            Console.WriteLine(cyberAttacks[3, 0] + "\n" + cyberAttacks[3, 1]);
                            break;

                        case "Cross-Site Scripting":
                            Console.WriteLine(cyberAttacks[4, 0] + "\n" + cyberAttacks[4, 1]);
                            break;

                        case "Man-in-the-Middle (MITM) attack":
                            Console.WriteLine(cyberAttacks[5, 0] + "\n" + cyberAttacks[5, 1]);
                            break;

                        default:
                            Console.WriteLine("Your response was invalid. Please try again.\n");
                            break;
                    }
                }
            }
            else if (input.Contains("security measures"))
            {
                for (int i = 0; i < securityMeasures.Length; i++)
                {
                    Console.WriteLine("~ " + securityMeasures[i, 0] + "\n");
                }

                Console.WriteLine("Would you like me to define these security measures? Select a response from the following options " + "\n -'No'\n -'Yes'\n You may choose one security measure to be defined\n");

                for (int i = 0; i < securityMeasures.Length; i++)
                {
                    switch (input)
                    {
                        case "No":
                            Console.WriteLine("Ok no problem\n Feel free to ask me anything else.");
                            break;

                        case "Yes":
                            Console.WriteLine(securityMeasures[i, 0] + "\n" + securityMeasures[i, 1]);
                            break;

                        case "Encription":
                            Console.WriteLine(securityMeasures[0, 0] + "\n" + securityMeasures[0, 1]);
                            break;

                        case "Two-factor authentication":
                            Console.WriteLine(securityMeasures[1, 0] + "\n" + securityMeasures[1, 1]);
                            break;

                        case "2FA":
                            Console.WriteLine(securityMeasures[1, 0] + "\n" + securityMeasures[1, 1]);
                            break;

                        case "Firewall":
                            Console.WriteLine(securityMeasures[2, 0] + "\n" + securityMeasures[2, 1]);
                            break;

                        case "Passkeys":
                            Console.WriteLine(securityMeasures[3, 0] + "\n" + securityMeasures[3, 1]);
                            break;

                        case "Patch Management":
                            Console.WriteLine(securityMeasures[4, 0] + "\n" + securityMeasures[4, 1]);
                            break;

                        default:
                            Console.WriteLine("Your response was invalid. Please try again.\n");
                            break;
                    }
                }
            }

            else
            {
                Console.WriteLine("Hmm... I didn’t quite understand that. Can you rephrase?");

            }

            //We've spoken of phishing attack as a type of cyber attack... here are a few oth

            Console.ResetColor();

            return input;
        }
    }
}
