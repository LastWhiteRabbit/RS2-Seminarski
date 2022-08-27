import 'package:flutter/material.dart';
import 'package:ironvault_mobile/providers/exercise_provider.dart';
import 'package:ironvault_mobile/providers/exercisetype_provider.dart';
import 'package:ironvault_mobile/providers/muscle_provider.dart';
import 'package:ironvault_mobile/providers/routine_provider.dart';
import 'package:ironvault_mobile/providers/routineclient_provider.dart';
import 'package:ironvault_mobile/providers/user_provider.dart';
import 'package:ironvault_mobile/screens/exercises/exercise_details_screen.dart';
import 'package:ironvault_mobile/screens/exercises/exercise_list_screen.dart';
import 'package:ironvault_mobile/screens/routine/routine_client_screen.dart';
import 'package:provider/provider.dart';
import 'login_page.dart';

void main() {
  runApp(MultiProvider(providers: [
    ChangeNotifierProvider(create: (_) => ExerciseProvider()),
    ChangeNotifierProvider(create: (_) => UserProvider()),
    ChangeNotifierProvider(create: (_) => ExerciseTypeProvider()),
    ChangeNotifierProvider(create: (_) => MuscleProvider()),
    ChangeNotifierProvider(create: (_) => RoutineProvider()),
    ChangeNotifierProvider(create: (_) => RoutineClientProvider()),
  ], child: const MyApp()));
}

class MyApp extends StatelessWidget {
  const MyApp({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
        debugShowCheckedModeBanner: true,
        theme: ThemeData(
          // Define the default brightness and colors.
          brightness: Brightness.light,
          primaryColor: Colors.deepPurple,
          textButtonTheme: TextButtonThemeData(
              style: TextButton.styleFrom(
                  primary: Colors.yellow,
                  textStyle: const TextStyle(
                      fontSize: 24,
                      fontWeight: FontWeight.bold,
                      fontStyle: FontStyle.italic))),

          // Define the default `TextTheme`. Use this to specify the default
          // text styling for headlines, titles, bodies of text, and more.
          textTheme: const TextTheme(
            headline1: TextStyle(fontSize: 72.0, fontWeight: FontWeight.bold),
            headline6: TextStyle(fontSize: 36.0, fontStyle: FontStyle.italic),
          ),
        ),
        home: LoginPage(),
        onGenerateRoute: (settings) {
          if (settings.name == ExerciseListScreen.routeName) {
            return MaterialPageRoute(
                builder: ((context) => ExerciseListScreen()));
          } else if (settings.name == RoutineClientScreen.routeName) {
            return MaterialPageRoute(
                builder: ((context) => RoutineClientScreen()));
          }

          var uri = Uri.parse(settings.name!);
          if (uri.pathSegments.length == 2 &&
              "/${uri.pathSegments.first}" == ExerciseDetailsScreen.routeName) {
            var id = uri.pathSegments[1];
            return MaterialPageRoute(
                builder: (context) => ExerciseDetailsScreen(id));
          }
        });
  }
}
