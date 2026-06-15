import 'package:flutter/material.dart';

class StartLessonButton extends StatelessWidget {
  const StartLessonButton({super.key});

  @override
  Widget build(BuildContext context) {
    return SizedBox(
      width: double.infinity,
      height: 48,
      child: ElevatedButton(
        onPressed: () {
          debugPrint('Start learning pressed');
        },
        style: ElevatedButton.styleFrom(
          backgroundColor: const Color(0xFF4A6984),
          foregroundColor: Colors.white,
        ),
        child: const Text('Start Learning'),
      ),
    );
  }
}
