using ATM.ConsoleApp.Interfaces;

namespace ATM.ConsoleApp;

public record ApplicationAction(string Description,
                                Action Action,
                                IPage? NextPage);
