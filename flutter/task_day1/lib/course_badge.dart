import 'package:flutter/material.dart';

class CourseBadge extends StatelessWidget {
  const CourseBadge({
    super.key,
    required this.text,
    required this.textColor,
    required this.backgroundColor,
  });

  final String text;
  final Color textColor;
  final Color backgroundColor;

  @override
  Widget build(BuildContext context) {
    return DecoratedBox(
      decoration: BoxDecoration(
        borderRadius: const BorderRadius.all(Radius.circular(999)),
        color: backgroundColor,
        border: Border.all(
          color: textColor,
          width: 1.2,
        ),
      ),
      child: Padding(
        padding: const EdgeInsets.symmetric(
          horizontal: 20,
          vertical: 10,
        ),
        child: Text(
          text,
          style: TextStyle(
            color: textColor,
            fontWeight: FontWeight.bold,
            fontSize: 16,
          ),
        ),
      ),
    );
  }
}
