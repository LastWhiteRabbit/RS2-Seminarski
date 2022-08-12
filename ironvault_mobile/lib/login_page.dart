import 'package:flutter/gestures.dart';
import 'package:flutter/material.dart';
import 'package:ironvault_mobile/common/theme_helper.dart';
import 'package:ironvault_mobile/providers/user_provider.dart';
import 'package:ironvault_mobile/screens/exercises/exercise_list_screen.dart';
import 'package:ironvault_mobile/screens/exercises/registration_page.dart';
import 'package:ironvault_mobile/utils/util.dart';
import 'package:provider/provider.dart';

class LoginPage extends StatefulWidget {
  const LoginPage({Key? key}) : super(key: key);

  @override
  State<LoginPage> createState() => _LoginPageState();
}

class _LoginPageState extends State<LoginPage> {
  TextEditingController _usernameController = TextEditingController();
  TextEditingController _passwordController = TextEditingController();
  late UserProvider _userProvider;

  @override
  Widget build(BuildContext context) {
    _userProvider = Provider.of<UserProvider>(context, listen: false);

    return Scaffold(
        appBar: AppBar(
          title: Text("IronVault"),
        ),
        body: SingleChildScrollView(
          child: Column(children: [
            Container(
                height: 400,
                decoration: new BoxDecoration(
                  gradient: new LinearGradient(
                    begin: const FractionalOffset(0, 0),
                    end: const FractionalOffset(1, 1),
                    colors: [
                      Color.fromARGB(255, 176, 205, 255),
                      Colors.blueAccent,
                    ],
                  ),
                ),
                child: AnimatedOpacity(
                  opacity: 1.0,
                  duration: Duration(milliseconds: 1200),
                  child: Center(
                      child: Container(
                          height: 140,
                          width: 140,
                          child: Center(
                            child: ClipOval(
                                child: Icon(
                              Icons.android_rounded,
                              size: 130,
                            )),
                          ),
                          decoration: BoxDecoration(
                              color: Colors.white,
                              borderRadius: BorderRadius.circular(100),
                              boxShadow: [
                                BoxShadow(
                                    color: Colors.black.withOpacity(0.3),
                                    blurRadius: 2.0,
                                    offset: Offset(5.0, 3.0),
                                    spreadRadius: 2.0)
                              ]))),
                )),
            Padding(
              padding: EdgeInsets.all(8),
              child: Container(
                decoration: BoxDecoration(
                    color: Colors.white,
                    borderRadius: BorderRadius.circular(10)),
                child: Column(children: [
                  Container(
                    padding: EdgeInsets.all(8),
                    decoration: BoxDecoration(
                        border: Border(bottom: BorderSide(color: Colors.grey))),
                    child: TextField(
                      controller: _usernameController,
                      decoration: ThemeHelper().textInputDecoration(
                          "Username", "Enter your username"),
                    ),
                  ),
                  Container(
                    padding: EdgeInsets.all(8),
                    child: TextField(
                      controller: _passwordController,
                      obscureText: true,
                      decoration: ThemeHelper().textInputDecoration(
                          "Password", "Enter your password"),
                    ),
                  ),
                ]),
              ),
            ),
            Container(
              margin: EdgeInsets.fromLTRB(10, 0, 10, 10),
              alignment: Alignment.topRight,
              child: Text(
                "Forgot password?",
                style: TextStyle(
                    fontSize: 14,
                    fontWeight: FontWeight.bold,
                    color: Colors.black),
              ),
            ),
            Container(
              child: InkWell(
                child: Center(
                    child: Text(
                  "Login".toUpperCase(),
                  style: TextStyle(
                      fontSize: 20,
                      fontWeight: FontWeight.bold,
                      color: Colors.white),
                )),
                onTap: () async {
                  try {
                    Authorization.username = _usernameController.text;
                    Authorization.password = _passwordController.text;

                    await _userProvider.get();

                    Navigator.pushNamed(context, ExerciseListScreen.routeName);
                  } catch (e) {
                    showDialog(
                        context: context,
                        builder: (BuildContext context) => AlertDialog(
                              title: Text("Error"),
                              content: Text(e.toString()),
                              actions: [
                                TextButton(
                                  child: Text("OK"),
                                  onPressed: () => Navigator.pop(context),
                                )
                              ],
                            ));
                  }
                },
              ),
              height: 50,
              width: 300,
              margin: EdgeInsets.all(8),
              decoration: ThemeHelper().buttonBoxDecoration(context),
            ),
            Container(
                margin: EdgeInsets.fromLTRB(10, 0, 10, 10),
                alignment: Alignment.center,
                child: Text.rich(TextSpan(children: [
                  TextSpan(
                      text: "Don't have an account? ",
                      style: TextStyle(
                          fontSize: 14,
                          fontWeight: FontWeight.bold,
                          color: Colors.black)),
                  TextSpan(
                      text: "Create one",
                      recognizer: TapGestureRecognizer()
                        ..onTap = () {
                          Navigator.push(
                              context,
                              MaterialPageRoute(
                                  builder: (context) => RegistrationPage()));
                        },
                      style: TextStyle(
                          fontSize: 14,
                          fontWeight: FontWeight.bold,
                          color: Colors.blueAccent))
                ])))
          ]),
        ));
  }
}
