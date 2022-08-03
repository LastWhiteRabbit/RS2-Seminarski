import 'package:flutter/material.dart';
import 'package:ironvault_mobile/providers/exercise_provider.dart';
import 'package:ironvault_mobile/screens/exercises/exercise_list_screen.dart';
import 'package:provider/provider.dart';
import 'login_page.dart';

void main() {
  runApp(MultiProvider(providers: [
    ChangeNotifierProvider(create: (_) => ExerciseProvider()),
  ], child: const MyApp()));
}

class MyApp extends StatelessWidget {
  const MyApp({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      debugShowCheckedModeBanner: false,
      home: LoginPage(),
      onGenerateRoute: (settings) {
        if (settings.name == ExerciseListScreen.routeName) {
          return MaterialPageRoute(builder: (context) => ExerciseListScreen());
        }
      },
    );
  }
}
